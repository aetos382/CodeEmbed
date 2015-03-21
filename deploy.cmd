@echo off

setlocal

set EXIT_CODE=0

if /i "%Configuration%" EQU "Debug" goto DEPLOY_DEBUG
if /i "%Configuration%" EQU "Release" goto DEPLOY_RELEASE

set EXIT_CODE=1
goto DEPLOY_END

:DEPLOY_DEBUG

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Site codeembed-dev.PublishSettings /p %deploy_password_dev% /d
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Api codeembed-dev.PublishSettings /p %deploy_password_dev% /d /t api/v1
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

goto DEPLOY_END

:DEPLOY_RELEASE

if /i "%APPVEYOR_REPO_TAG%" NEQ "true" GOTO DEPLOY_END

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Site codeembed.PublishSettings /p %deploy_password% /d
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

"%ChocolateyInstall%\bin\WAWSDeploy.exe" Publish\CodeEmbed.Web.Api codeembed.PublishSettings /p %deploy_password% /d /t api/v1
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto DEPLOY_END

goto DEPLOY_END

:DEPLOY_END

endlocal & exit /b %EXIT_CODE%
