Write-Host "[MCIO] Limpando pastas bin e obj"

Write-Host "    ./src/OutputEnvelop.FluentValidation/bin"
if (Test-Path "./src/OutputEnvelop.FluentValidation/bin" -PathType Container)
{
    Remove-Item -Path "./src/OutputEnvelop.FluentValidation/bin" -Recurse -Force
}

Write-Host "    ./src/OutputEnvelop.FluentValidation/obj"
if (Test-Path "./src/OutputEnvelop.FluentValidation/obj" -PathType Container)
{
    Remove-Item -Path "./src/OutputEnvelop.FluentValidation/obj" -Recurse -Force
}

Write-Host "    ./tst/UnitTests/bin"
if (Test-Path "./tst/UnitTests/bin" -PathType Container)
{
    Remove-Item -Path "./tst/UnitTests/bin" -Recurse -Force
}

Write-Host "    ./tst/UnitTests/obj"
if (Test-Path "./tst/UnitTests/obj" -PathType Container)
{
    Remove-Item -Path "./tst/UnitTests/obj" -Recurse -Force
}

Write-Host "    ./benchs/Benchmarks/bin"
if (Test-Path "./benchs/Benchmarks/bin" -PathType Container)
{
    Remove-Item -Path "./benchs/Benchmarks/bin" -Recurse -Force
}

Write-Host "    ./benchs/Benchmarks/obj"
if (Test-Path "./benchs/Benchmarks/obj" -PathType Container)
{
    Remove-Item -Path "./benchs/Benchmarks/obj" -Recurse -Force
}


Write-Host "[MCIO] Limpando arquivos gerados nos teste"

Write-Host "    ./tst/UnitTests/.stryker-output"
if (Test-Path "./tst/UnitTests/.stryker-output" -PathType Container)
{
    Remove-Item -Path "./tst/UnitTests/.stryker-output" -Recurse -Force
}

Write-Host "    ./tst/UnitTests/Coverage"
if (Test-Path "./tst/UnitTests/Coverage" -PathType Container)
{
    Remove-Item -Path "./tst/UnitTests/Coverage" -Recurse -Force
}

Write-Host "[MCIO] Limpando pastas das ferramentas de CLI"

Write-Host "    ./.reportgenerator"
if (Test-Path "./.reportgenerator" -PathType Container)
{
    Remove-Item -Path "./.reportgenerator" -Recurse -Force
}
Write-Host "    ./.stryker"
if (Test-Path "./.stryker" -PathType Container)
{
    Remove-Item -Path "./.stryker" -Recurse -Force
}