@echo off

setlocal

pushd "%~dp0"

set EXIT_CODE=0

call CodeEmbed.Web.Site\preBuild.cmd
if errorlevel 1 set EXIT_CODE=%ERRORLEVEL% && goto END_PREBUILD

:END_PREBUILD

popd

endlocal && exit /b %EXIT_CODE%
