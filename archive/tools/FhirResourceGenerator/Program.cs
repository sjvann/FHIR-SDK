using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FhirResourceGenerator.Core;
using FhirResourceGenerator.Parsers;
using FhirResourceGenerator.Generators;
using FhirResourceGenerator.Templates;
using FhirResourceGenerator.Configuration;
using FhirResourceGenerator.Utilities;

namespace FhirResourceGenerator;

/// <summary>
/// FHIR 資源生成器主程式
/// </summary>
/// <remarks>
/// 基於 FHIR 官方 StructureDefinition 自動生成符合現代化 SDK 要求的資源類別
/// </remarks>
public class Program
{
    public static async Task<int> Main(string[] args)
    {
        // 建立主命令
        var rootCommand = new RootCommand("FHIR Resource Generator - 基於 FHIR 官方定義檔的智能資源產生器");

        // 生成命令
        var generateCommand = CreateGenerateCommand();
        var validateCommand = CreateValidateCommand();
        var compareCommand = CreateCompareCommand();
        var reportCommand = CreateReportCommand();
        var updateCommand = CreateUpdateCommand();

        rootCommand.AddCommand(generateCommand);
        rootCommand.AddCommand(validateCommand);
        rootCommand.AddCommand(compareCommand);
        rootCommand.AddCommand(reportCommand);
        rootCommand.AddCommand(updateCommand);

        return await rootCommand.InvokeAsync(args);
    }

    /// <summary>
    /// 創建生成命令
    /// </summary>
    private static Command CreateGenerateCommand()
    {
        var command = new Command("generate", "生成 FHIR 資源")
        {
            new Option<string>("--version", "FHIR 版本 (R4, R5, R6)") { IsRequired = true },
            new Option<string>("--definitions-path", "定義檔路徑") { IsRequired = false },
            new Option<string>("--output-path", "輸出路徑") { IsRequired = false },
            new Option<string[]>("--resources", "特定資源名稱 (留空則生成全部)") { IsRequired = false },
            new Option<bool>("--force", "強制覆蓋現有檔案") { IsRequired = false },
            new Option<bool>("--include-tests", "包含測試專案") { IsRequired = false }
        };

        command.SetHandler(async (string version, string? definitionsPath, string? outputPath,
            string[]? resources, bool force, bool includeTests) =>
        {
            using var host = CreateHost();
            var generator = host.Services.GetRequiredService<IResourceGenerator>();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            try
            {
                logger.LogInformation("?? 開始生成 FHIR {Version} 資源...", version);

                var context = new GeneratorContext
                {
                    Version = version,
                    DefinitionsPath = definitionsPath ?? $"Definitions/{version}",
                    OutputPath = outputPath ?? $"FhirCore.{version}",
                    TargetResources = resources?.ToList(),
                    ForceOverwrite = force,
                    IncludeTests = includeTests
                };

                var result = await generator.GenerateProjectAsync(context);

                if (result.Success)
                {
                    logger.LogInformation("? 生成完成！");
                    logger.LogInformation("?? 統計：{ResourceCount} 個資源，{FileCount} 個檔案",
                        result.ResourcesGenerated, result.FilesGenerated);
                }
                else
                {
                    logger.LogError("? 生成失敗：{Error}", result.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "? 生成過程中發生錯誤");
            }
        });

        return command;
    }

    /// <summary>
    /// 創建驗證命令
    /// </summary>
    private static Command CreateValidateCommand()
    {
        var command = new Command("validate", "驗證定義檔")
        {
            new Option<string>("--definitions-path", "定義檔路徑") { IsRequired = true }
        };

        command.SetHandler(async (string definitionsPath) =>
        {
            using var host = CreateHost();
            var parser = host.Services.GetRequiredService<IDefinitionParser>();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            try
            {
                logger.LogInformation("?? 驗證定義檔：{Path}", definitionsPath);

                var definitions = await parser.ParseResourceDefinitionsAsync(definitionsPath);
                var validDefinitions = definitions.Count();

                logger.LogInformation("? 驗證完成！找到 {Count} 個有效的資源定義", validDefinitions);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "? 驗證過程中發生錯誤");
            }
        });

        return command;
    }

    /// <summary>
    /// 創建比較命令
    /// </summary>
    private static Command CreateCompareCommand()
    {
        var command = new Command("compare", "比較版本差異")
        {
            new Option<string>("--from", "來源版本") { IsRequired = true },
            new Option<string>("--to", "目標版本") { IsRequired = true },
            new Option<string>("--output", "報告輸出檔案") { IsRequired = false }
        };

        command.SetHandler(async (string from, string to, string? output) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? 比較 {From} 與 {To} 版本差異", from, to);
            logger.LogInformation("?? 比較功能將在未來版本中實作");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// 創建報告命令
    /// </summary>
    private static Command CreateReportCommand()
    {
        var command = new Command("report", "生成專案報告")
        {
            new Option<string>("--version", "FHIR 版本") { IsRequired = true },
            new Option<string>("--output", "報告輸出檔案") { IsRequired = false }
        };

        command.SetHandler(async (string version, string? output) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? 生成 {Version} 版本報告", version);
            logger.LogInformation("?? 報告功能將在未來版本中實作");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// 創建更新命令
    /// </summary>
    private static Command CreateUpdateCommand()
    {
        var command = new Command("update", "更新現有專案")
        {
            new Option<string>("--version", "FHIR 版本") { IsRequired = true },
            new Option<string>("--target", "目標專案路徑") { IsRequired = true }
        };

        command.SetHandler(async (string version, string target) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? 更新 {Version} 專案：{Target}", version, target);
            logger.LogInformation("?? 更新功能將在未來版本中實作");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// 創建服務主機
    /// </summary>
    private static IHost CreateHost()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // 註冊核心服務
                services.AddSingleton<IDefinitionParser, StructureDefinitionParser>();
                services.AddSingleton<IResourceGenerator, ResourceClassGenerator>();
                services.AddSingleton<ITemplateEngine, ScribanTemplateEngine>();
                
                // 註冊輔助服務
                services.AddSingleton<ElementDefinitionParser>();
                services.AddSingleton<FhirTypeResolver>();
                services.AddSingleton<ConstraintProcessor>();
                services.AddSingleton<BackboneElementGenerator>();
                services.AddSingleton<ChoiceTypeGenerator>();
                services.AddSingleton<FactoryMethodGenerator>();
                services.AddSingleton<ProjectGenerator>();
                
                // 註冊工具類
                services.AddSingleton<NamingUtils>();
                services.AddSingleton<ValidationUtils>();
                services.AddSingleton<FileUtils>();
                
                // 註冊配置
                services.AddSingleton<GeneratorConfig>();
                services.AddSingleton<R4MappingConfig>();
            })
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.SetMinimumLevel(LogLevel.Information);
            })
            .Build();
    }
}