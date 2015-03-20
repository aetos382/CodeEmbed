@echo off

setlocal

set EXIT_CODE=0

if /i "%APPVEYOR_REPO_TAG%" NEQ "true" GOTO DEPLOY_END

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Site codeembed.PublishSettings /p %deploy_password% /d
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Api codeembed.PublishSettings /p %deploy_password% /d /t api/v1
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

:DEPLOY_END

endlocal & exit /b %EXIT_CODE%
