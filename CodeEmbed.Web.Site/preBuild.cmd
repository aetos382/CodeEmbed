@echo off

pushd "%~dp0"

call npm install
call bower install
call gulp

popd

exit /b
