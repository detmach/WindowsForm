echo off
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v2.0.50727
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v3.5
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
REM set msBuildDir=C:\Program Files (x86)\MSBuild\12.0\Bin
set msBuildDir=C:\Program Files (x86)\MSBuild\14.0\Bin
call "%msBuildDir%\msbuild.exe"
set msBuildDir=
cd WinForm\bin\Debug
start WinForm.exe

echo "Program Suan Calisti. Dogrumu?"
set /p DUMMY=Enter Tusuna Bas Dostum...
 
start WinForm.exe bunuyap

echo "Eðer Programa bakarsan programda bir uyari cikti ve bunuyap yaziyor"

set /p DUMMY=Devam Etmek icin Enter Tusuna Bas
 
start WinForm.exe sunuyap

echo "Eðer Programa bakarsan programda bir uyari cikti ve yadabunuyap yaziyor"

set /p DUMMY=Devam Etmek icin Enter Tusuna Bas
 
start WinForm.exe butonabas

echo "Eðer Programa bakarsan programda ordaki buton eventi calisti :)"