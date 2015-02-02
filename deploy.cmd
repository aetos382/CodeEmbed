@echo off

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\Debug\CodeEmbed.Web.Site codeembed-dev.PublishSettings /p %deploy_password% /d /t site
"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\Debug\CodeEmbed.Web.Api codeembed-dev.PublishSettings /p %deploy_password% /d /t api\v1
