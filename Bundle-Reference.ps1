function Bundle-Reference {

  [CmdletBinding(SupportsShouldProcess, ConfirmImpact = 'Medium', DefaultParameterSetName = 'Path')]

  param(
    [Parameter(ParameterSetName = 'Path', Mandatory, Position = 0, ValueFromPipeline, ValueFromPipelineByPropertyName)]
    [SupportsWildcards()]
    [string[]] $Path,

    [Parameter(ParameterSetName = 'LiteralPath', Mandatory, Position = 0, ValueFromPipeline, ValueFromPipelineByPropertyName)]
    [Alias('PSPath')]
    [string[]] $LiteralPath,
    
    [string] $BeginBlockPattern = '^(\s*)<!-- begin bundle:(.+?) -->\s*$',
    
    [string] $EndBlockPattern = '<!-- end bundle -->',
    
    [scriptblock] $Script)

  process {
  
    if ($PSCmdlet.ParameterSetName -eq 'Path') {
      $files = Resolve-Path -Path $Path
    }
    else {
      $files = Resolve-Path -Path $LiteralPath
    }

    @($files) | % {

      $file = $_

      if (!$PSCmdlet.ShouldProcess($file)) {
        return
      }

      $bundling = $false

      $lines = Get-Content $file

      $output = @($lines) | % {

        $line = $_

        if ($line -match $BeginBlockPattern) {
          if ($Script) {
            $result = & $Script $line $Matches
          }
          else {
            $leadingSpace = $Matches[1]
            $bundle = $Matches[2]

            "${leadingSpace}${bundle}"
          }

          $bundling = $true
        }
        elseif ($line -match $EndBlockPattern) {
          if ($bundling) {
            $bundling = $false
          }
          else {
            $line
          }
        }
        else {
          if (!$bundling) {
            $line
          }
        }

      }

      Set-Content $file -Value $output -Encoding 'UTF8'
    }

  }
}

Push-Location $PSScriptRoot

try {
	Get-ChildItem 'CodeEmbed.Web.Site' -Filter '*.cshtml' -Recurse | Bundle-Reference
}
finally {
	Pop-Location
}
