@ECHO OFF
ECHO Demo Automation Executed Started.


set testcategory=OrderTest
set dllpath=D:\c#\UnitTesting\ASSIGNMENT09\ASSIGNMENT09\bin\Debug\ASSIGNMENT09.dll
set trxerpath=C:\TestSummaryReport\
set SummaryReportPath=C:\TestSummaryReport

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=c:\TestSummaryReport\%filename%\%filename%.trx"

cd %trxerpath%

TrxToHTML.exe %SummaryReportPath%\%filename%\

PAUSE