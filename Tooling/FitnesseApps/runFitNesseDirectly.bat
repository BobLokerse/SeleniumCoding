@echo off
setlocal
TITLE FitNesse Server Runner @8980
SET PATH=.\BrowserServers;%PATH%

java -jar fitnesse-standalone.jar -p 8980
pause
