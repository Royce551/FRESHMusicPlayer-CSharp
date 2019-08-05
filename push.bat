@echo off
set /p name=Enter name of commit: 
git add *
git commit -m "%name$"
git push