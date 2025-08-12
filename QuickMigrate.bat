@echo off
:: FHIR R5 資源遷移加速工具 - 快速執行入口
:: 選擇最適合的遷移策略並執行

echo.
echo ============================================================
echo ?? FHIR R5 資源遷移加速工具
echo ============================================================
echo.
echo 請選擇執行模式:
echo.
echo [1] ?? 混合智能模式 (推薦) - 高優先級資源
echo [2] ?? 自動化遷移模式 - 完整遷移現有資源  
echo [3] ?? AI 批量生成模式 - 快速生成新資源
echo [4] ?? 分析模式 - 僅分析當前狀況
echo [5] ?? 混合智能模式 - 所有資源
echo [0] 退出
echo.

set /p choice="請輸入選擇 (0-5): "

if "%choice%"=="1" (
    echo.
    echo ?? 執行混合智能模式 - 高優先級資源...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Hybrid" -Priority "High"
    goto :end
)

if "%choice%"=="2" (
    echo.
    echo ?? 執行自動化遷移模式...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Migration"
    goto :end
)

if "%choice%"=="3" (
    echo.
    echo ?? 執行 AI 批量生成模式...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "AI" -Priority "High"
    goto :end
)

if "%choice%"=="4" (
    echo.
    echo ?? 執行分析模式...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Analysis"
    goto :end
)

if "%choice%"=="5" (
    echo.
    echo ?? 執行混合智能模式 - 所有資源...
    powershell.exe -ExecutionPolicy Bypass -File "scripts\Accelerate-R5Migration.ps1" -Mode "Hybrid" -Priority "All"
    goto :end
)

if "%choice%"=="0" (
    echo 退出...
    goto :end
)

echo 無效的選擇，請重新執行。

:end
echo.
echo 按任意鍵繼續...
pause >nul