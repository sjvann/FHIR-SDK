namespace CodeGen;

internal sealed class CliArgs
{
    public string DefinitionsRoot { get; }
    public string Version { get; }
    public string OutputProject { get; }
    public string? Include { get; }
    public bool DryRun { get; }
    public bool EmitExamples { get; }
    public string? ExamplesSource { get; }

    private CliArgs(string defs, string ver, string proj, string? inc, bool dry, bool emit, string? examplesSource)
    {
        DefinitionsRoot = defs;
        Version = ver;
        OutputProject = proj;
        Include = inc;
        DryRun = dry;
        EmitExamples = emit;
        ExamplesSource = examplesSource;
    }

    public static CliArgs Parse(string[] args)
    {
        string GetArg(string name, string? def = null)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (string.Equals(args[i], name, StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                    return args[i + 1];
                if (args[i].StartsWith(name + "=", StringComparison.OrdinalIgnoreCase))
                    return args[i].Substring(name.Length + 1);
            }
            return def ?? string.Empty;
        }
        bool GetBool(string name, bool def)
        {
            var v = GetArg(name, def.ToString());
            return v.Equals("true", StringComparison.OrdinalIgnoreCase) || v == "1";
        }

        var defs = GetArg("--definitions-root");
        var ver = GetArg("--version", "R5");
        var proj = GetArg("--output-project");
        var inc = GetArg("--include", null);
        var dry = GetBool("--dry-run", true);
        var emit = GetBool("--emit-examples", true);
        var exsrc = GetArg("--examples-source", null);

        if (string.IsNullOrWhiteSpace(defs) || string.IsNullOrWhiteSpace(proj))
            throw new ArgumentException("Usage: --definitions-root <path|folder> --version <version> --output-project <csproj|folder> [--include <A,B>] [--dry-run true|false] [--emit-examples true|false] [--examples-source <folder>]");
        if (string.IsNullOrWhiteSpace(ver))
            throw new ArgumentException("--version is required (e.g., R4, R5, R6)");

        return new CliArgs(defs, ver, proj, inc, dry, emit, exsrc);
    }
}

