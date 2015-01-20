Push-Location $PSScriptRoot

try {
	$path = Convert-Path .\CodeEmbed.Web.Api\Web.config
	$xml = [xml] (Get-Content $path)
	$node = $xml.SelectSingleNode('/configuration/applicationSettings/CodeEmbed.Web.Api.Properties.Settings/setting[@name = "AccessToken"]')
	$node.value = $env:github_oauth_token
	$xml.Save($path)
}
finally {
	Pop-Location
}
