function Set-OAuthToken {

	param(
		[Parameter(Mandatory)]
		[string] $Path)

	$fullpath = Convert-Path $Path
	$xml = [xml] (Get-Content $fullpath)
	
	$element = $xml.CreateElement('add')
	$element.SetAttribute('key', 'OAuthToken')
	$element.SetAttribute('value', $env:github_oauth_token)
	
	$settings = $xml.SelectSingleNode('/configuration/appSettings')
	$settings.AppendChild($element)
	
	$xml.Save($fullpath)
}

Push-Location $PSScriptRoot

try {
	Set-OAuthToken .\CodeEmbed.GitHubClient.Tests\App.config
	Set-OAuthToken .\CodeEmbed.Web.Api\Web.config
	Set-OAuthToken .\CodeEmbed.Web.Api.Tests\App.config
}
finally {
	Pop-Location
}
