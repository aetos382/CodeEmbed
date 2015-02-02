@echo off

if "%Configuration%" == "Release" goto DEPLOY_RELEASE

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Site codeembed-dev.PublishSettings /p %deploy_password% /d
"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Api codeembed-dev.PublishSettings /p %deploy_password% /d /t api/v1

:DEPLOY_RELEASE

exit /b
