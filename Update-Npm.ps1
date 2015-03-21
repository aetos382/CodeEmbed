param(
  [Parameter(Mandatory, Position = 0)]
  [string] $Version,
  
  [Parameter(Position = 1)]
  [ValidateSet('x86', 'x64')]
  [string] $Bitness = 'x86')

Import-Module 'nodejs-utils' -Force

$latest = Get-NodeJsLatestBuild $Version
Update-NodeJsInstallation $latest $Bitness

npm install -g npm
if ($LASTEXITCODE -ne 0) {
  throw 'npm update failed'
}

$nodePath = & "$env:ComSpec" /c where node.exe
if (!$nodePath) {
  throw 'node.exe not found'
}

$nodePath = Split-Path $nodePath

Push-Location $nodePath

try {

  Remove-Item 'npm'
  Remove-Item 'npm.cmd'
  Remove-Item 'node_modules' -Recurse
  
}
finally {

  Pop-Location

}

npm -v
