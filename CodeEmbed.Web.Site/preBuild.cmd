@echo off

setlocal

set EXIT_CODE=0

pushd "%~dp0"

call npm install
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto END_PREBUILD

call bower install
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto END_PREBUILD

call gulp
if ERRORLEVEL 1 set EXIT_CODE=%ERRORLEVEL% && goto END_PREBUILD

:END_PREBUILD

popd

endlocal && exit /b %EXIT_CODE%
