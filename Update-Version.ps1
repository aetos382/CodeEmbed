function Set-BuildVersion {

  param(
    [Parameter(Mandatory, Position = 0)]
    [string] $Path,

    [Parameter(Mandatory, Position = 1)]
    [string] $Version)

  $fullpath = Convert-Path $Path
  $xml = [xml] (Get-Content $fullpath)
	
  $settings = $xml.SelectSingleNode('/configuration/appSettings')
  $element = $settings.SelectSingleNode('add[@key = "Version"]')

  if ($element -eq $null) {
    $element = $xml.CreateElement('add')
    $element.SetAttribute('key', 'Version')

    $settings.AppendChild($element) | Out-Null
  }

  $element.SetAttribute('value', $Version)

  $xml.Save($fullpath)
}

Push-Location $PSScriptRoot

try {

  $version = "$env:APPVEYOR_BUILD_VERSION ($env:APPVEYOR_REPO_COMMIT) / $env:Configuration"
  Set-BuildVersion '.\CodeEmbed.Web.Site\Web.config' $version

}
finally {

  Pop-Location

}
