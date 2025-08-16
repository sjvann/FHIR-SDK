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
/// FHIR �귽�ͦ����D�{��
/// </summary>
/// <remarks>
/// ��� FHIR �x�� StructureDefinition �۰ʥͦ��ŦX�{�N�� SDK �n�D���귽���O
/// </remarks>
public class Program
{
    public static async Task<int> Main(string[] args)
    {
        // �إߥD�R�O
        var rootCommand = new RootCommand("FHIR Resource Generator - ��� FHIR �x��w�q�ɪ�����귽���;�");

        // �ͦ��R�O
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
    /// �Ыإͦ��R�O
    /// </summary>
    private static Command CreateGenerateCommand()
    {
        var command = new Command("generate", "�ͦ� FHIR �귽")
        {
            new Option<string>("--version", "FHIR ���� (R4, R5, R6)") { IsRequired = true },
            new Option<string>("--definitions-path", "�w�q�ɸ��|") { IsRequired = false },
            new Option<string>("--output-path", "��X���|") { IsRequired = false },
            new Option<string[]>("--resources", "�S�w�귽�W�� (�d�ūh�ͦ�����)") { IsRequired = false },
            new Option<bool>("--force", "�j���л\�{���ɮ�") { IsRequired = false },
            new Option<bool>("--include-tests", "�]�t���ձM��") { IsRequired = false }
        };

        command.SetHandler(async (string version, string? definitionsPath, string? outputPath,
            string[]? resources, bool force, bool includeTests) =>
        {
            using var host = CreateHost();
            var generator = host.Services.GetRequiredService<IResourceGenerator>();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            try
            {
                logger.LogInformation("?? �}�l�ͦ� FHIR {Version} �귽...", version);

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
                    logger.LogInformation("? �ͦ������I");
                    logger.LogInformation("?? �έp�G{ResourceCount} �Ӹ귽�A{FileCount} ���ɮ�",
                        result.ResourcesGenerated, result.FilesGenerated);
                }
                else
                {
                    logger.LogError("? �ͦ����ѡG{Error}", result.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "? �ͦ��L�{���o�Ϳ��~");
            }
        });

        return command;
    }

    /// <summary>
    /// �Ы����ҩR�O
    /// </summary>
    private static Command CreateValidateCommand()
    {
        var command = new Command("validate", "���ҩw�q��")
        {
            new Option<string>("--definitions-path", "�w�q�ɸ��|") { IsRequired = true }
        };

        command.SetHandler(async (string definitionsPath) =>
        {
            using var host = CreateHost();
            var parser = host.Services.GetRequiredService<IDefinitionParser>();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            try
            {
                logger.LogInformation("?? ���ҩw�q�ɡG{Path}", definitionsPath);

                var definitions = await parser.ParseResourceDefinitionsAsync(definitionsPath);
                var validDefinitions = definitions.Count();

                logger.LogInformation("? ���ҧ����I��� {Count} �Ӧ��Ī��귽�w�q", validDefinitions);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "? ���ҹL�{���o�Ϳ��~");
            }
        });

        return command;
    }

    /// <summary>
    /// �Ыؤ���R�O
    /// </summary>
    private static Command CreateCompareCommand()
    {
        var command = new Command("compare", "��������t��")
        {
            new Option<string>("--from", "�ӷ�����") { IsRequired = true },
            new Option<string>("--to", "�ؼЪ���") { IsRequired = true },
            new Option<string>("--output", "���i��X�ɮ�") { IsRequired = false }
        };

        command.SetHandler(async (string from, string to, string? output) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? ��� {From} �P {To} �����t��", from, to);
            logger.LogInformation("?? ����\��N�b���Ӫ�������@");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// �Ыس��i�R�O
    /// </summary>
    private static Command CreateReportCommand()
    {
        var command = new Command("report", "�ͦ��M�׳��i")
        {
            new Option<string>("--version", "FHIR ����") { IsRequired = true },
            new Option<string>("--output", "���i��X�ɮ�") { IsRequired = false }
        };

        command.SetHandler(async (string version, string? output) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? �ͦ� {Version} �������i", version);
            logger.LogInformation("?? ���i�\��N�b���Ӫ�������@");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// �Ыا�s�R�O
    /// </summary>
    private static Command CreateUpdateCommand()
    {
        var command = new Command("update", "��s�{���M��")
        {
            new Option<string>("--version", "FHIR ����") { IsRequired = true },
            new Option<string>("--target", "�ؼбM�׸��|") { IsRequired = true }
        };

        command.SetHandler(async (string version, string target) =>
        {
            using var host = CreateHost();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            logger.LogInformation("?? ��s {Version} �M�סG{Target}", version, target);
            logger.LogInformation("?? ��s�\��N�b���Ӫ�������@");

            await Task.CompletedTask;
        });

        return command;
    }

    /// <summary>
    /// �ЫتA�ȥD��
    /// </summary>
    private static IHost CreateHost()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // ���U�֤ߪA��
                services.AddSingleton<IDefinitionParser, StructureDefinitionParser>();
                services.AddSingleton<IResourceGenerator, ResourceClassGenerator>();
                services.AddSingleton<ITemplateEngine, ScribanTemplateEngine>();
                
                // ���U���U�A��
                services.AddSingleton<ElementDefinitionParser>();
                services.AddSingleton<FhirTypeResolver>();
                services.AddSingleton<ConstraintProcessor>();
                services.AddSingleton<BackboneElementGenerator>();
                services.AddSingleton<ChoiceTypeGenerator>();
                services.AddSingleton<FactoryMethodGenerator>();
                services.AddSingleton<ProjectGenerator>();
                
                // ���U�u����
                services.AddSingleton<NamingUtils>();
                services.AddSingleton<ValidationUtils>();
                services.AddSingleton<FileUtils>();
                
                // ���U�t�m
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