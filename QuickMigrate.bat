@echo off
:: FHIR R5 �귽�E���[�t�u�� - �ֳt����J�f
:: ��ܳ̾A�X���E�������ð���

echo.
echo ============================================================
echo ?? FHIR R5 �귽�E���[�t�u��
echo ============================================================
echo.
echo �п�ܰ���Ҧ�:
echo.
echo [1] ?? �V�X����Ҧ� (����) - ���u���Ÿ귽
echo [2] ?? �۰ʤƾE���Ҧ� - ����E���{���귽  
echo [3] ?? AI ��q�ͦ��Ҧ� - �ֳt�ͦ��s�귽
echo [4] ?? ���R�Ҧ� - �Ȥ��R��e���p
echo [5] ?? �V�X����Ҧ� - �Ҧ��귽
echo [0] �h�X
echo.

set /p choice="�п�J��� (0-5): "

if "%choice%"=="1" (
    echo.
    echo ?? ����V�X����Ҧ� - ���u���Ÿ귽...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Hybrid" -Priority "High"
    goto :end
)

if "%choice%"=="2" (
    echo.
    echo ?? ����۰ʤƾE���Ҧ�...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Migration"
    goto :end
)

if "%choice%"=="3" (
    echo.
    echo ?? ���� AI ��q�ͦ��Ҧ�...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "AI" -Priority "High"
    goto :end
)

if "%choice%"=="4" (
    echo.
    echo ?? ������R�Ҧ�...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Analysis"
    goto :end
)

if "%choice%"=="5" (
    echo.
    echo ?? ����V�X����Ҧ� - �Ҧ��귽...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Hybrid" -Priority "All"
    goto :end
)

if "%choice%"=="0" (
    echo �h�X...
    goto :end
)

echo �L�Ī���ܡA�Э��s����C

:end
echo.
echo �����N���~��...
pause >nul