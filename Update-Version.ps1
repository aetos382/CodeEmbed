function Set-BuildVersion {

  param(
    [Parameter(Mandatory, Position = 0)]
    [string] $Path)

  $fullpath = Convert-Path $Path
  $xml = [xml] (Get-Content $fullpath)
	
  $settings = $xml.SelectSingleNode('/configuration/appSettings')

  $buildNo = $xml.CreateElement('add')
  $buildNo.SetAttribute('key', 'ver:BuildNo')
  $buildNo.SetAttribute('value', $env:APPVEYOR_BUILD_VERSION)
  $settings.AppendChild($buildNo) | Out-Null

  $branch = $xml.CreateElement('add')
  $branch.SetAttribute('key', 'ver:Branch')
  $branch.SetAttribute('value', $env:APPVEYOR_REPO_BRANCH)
  $settings.AppendChild($branch) | Out-Null

  $commit = $xml.CreateElement('add')
  $commit.SetAttribute('key', 'ver:Commit')
  $commit.SetAttribute('value', $env:APPVEYOR_REPO_COMMIT)
  $settings.AppendChild($commit) | Out-Null

  $configuration = $xml.CreateElement('add')
  $configuration.SetAttribute('key', 'ver:Configuration')
  $configuration.SetAttribute('value', $env:Configuration)
  $settings.AppendChild($configuration) | Out-Null

  $xml.Save($fullpath)
}

Push-Location $PSScriptRoot

try {

  Set-BuildVersion '.\CodeEmbed.Web.Site\Web.config'

}
finally {

  Pop-Location

}
