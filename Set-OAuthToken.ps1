function Set-OAuthToken {

	param(
		[Parameter(Mandatory, Position = 0)]
		[string] $Path)

	$fullpath = $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath($Path)
	$xml = New-Object 'System.Xml.XmlDocument'
	
	$appSettings = $xml.CreateElement('appSettings')
	
	$add = $xml.CreateElement('add')
	$add.SetAttribute('key', 'OAuthToken')
	$add.SetAttribute('value', $env:github_oauth_token)
	
	$appSettings.AppendChild($add) | Out-Null
	
	$xml.AppendChild($appSettings) | Out-Null
	
	$xml.Save($fullpath)
}

Push-Location $PSScriptRoot

try {
	Set-OAuthToken '.\CodeEmbed.GitHubClient.Tests\appSettings.local.config'
	Set-OAuthToken '.\CodeEmbed.Web.Api\appSettings.local.config'
	Set-OAuthToken '.\CodeEmbed.Web.Api.Tests\appSettings.local.config'
}
finally {
	Pop-Location
}
