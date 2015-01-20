function Set-OAuthToken {

	param(
		[Parameter(Mandatory)]
		[string] $Path)

	$fullpath = Convert-Path $Path
	$xml = [xml] (Get-Content $fullpath)
	$node = $xml.SelectSingleNode('/configuration/applicationSettings/CodeEmbed.Web.Api.Properties.Settings/setting[@name = "AccessToken"]')
	$node.value = $env:github_oauth_token
	$xml.Save($fullpath)
}

Push-Location $PSScriptRoot

try {
	Set-OAuthToken .\CodeEmbed.Web.Api\Web.config
	Set-OAuthToken .\CodeEmbed.Web.Api.Tests\App.config
}
finally {
	Pop-Location
}
