Add-Type -AssemblyName System.IO.Compression.FileSystem

$zipPath = "Definitions/R4/definitions.json.zip"
$zip = [System.IO.Compression.ZipFile]::OpenRead($zipPath)

Write-Host "ZIP 檔案內容:" -ForegroundColor Green
Write-Host "總檔案數: $($zip.Entries.Count)" -ForegroundColor Yellow

foreach ($entry in $zip.Entries) {
    Write-Host "  $($entry.Name) - $($entry.Length) bytes" -ForegroundColor Cyan
}

$zip.Dispose() 