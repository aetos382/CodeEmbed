$dir = Join-Path $PSScriptRoot 'Views'
$views = Get-ChildItem $dir -Recurse -Filter '*.cshtml'
$encoding = New-Object 'System.Text.UTF8Encoding' $true

$views | % {

  $path = $_.FullName;

  $text = [System.IO.File]::ReadAllText($path);
  [System.IO.File]::WriteAllText($path, $text, $encoding);

}
