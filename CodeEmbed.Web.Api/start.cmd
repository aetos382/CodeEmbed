@echo off

set iisexpress=C:\Program Files\IIS Express\iisexpress.exe
set apppath=%~dp0
set port=57250

if "%apppath:~-1%" == "\" set apppath=%apppath:~0,-1%

"%iisexpress%" /path:"%apppath%" /port:%port%
