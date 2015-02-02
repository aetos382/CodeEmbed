@echo off

if "%Configuration%" == "Release" goto DEPLOY_RELEASE

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Site codeembed-dev.PublishSettings /p %deploy_password% /d /v /t site
"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Api codeembed-dev.PublishSettings /p %deploy_password% /d /v /t api\v1

:DEPLOY_RELEASE

exit /b
