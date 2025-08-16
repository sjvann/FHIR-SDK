using CodeGen.Generators;
using CodeGen.Models;
using CodeGen.Services;

namespace CodeGen;

internal static class GenerationRunner
{
    public static void Run(
        string ns,
        IReadOnlyList<string> selectedList,
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> docs,
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> choices,
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> typeInfo,
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, Cardinality>> cards,
        string outDir,
        bool dry,
        Action<string, string, bool> writeFile)
    {
        var emitter = new PropertyEmitter();
        var gen = new PoCGenerator(emitter, docs, choices, typeInfo);

        var totalCount = selectedList.Count;
        for (int i = 0; i < totalCount; i++)
        {
            var r = selectedList[i];
            if (i - 1 >= 0) Console.WriteLine($"[CodeGen] {i}/{totalCount} {selectedList[i-1]}");
            Console.WriteLine($"[CodeGen] {i+1}/{totalCount} {r}");
            if (i + 1 < totalCount) Console.WriteLine($"[CodeGen] {i+2}/{totalCount} {selectedList[i+1]}");

            var sw = System.Diagnostics.Stopwatch.StartNew();
            var cardMap = cards.GetValueOrDefault(r, new Dictionary<string, Cardinality>());

            var src = gen.BuildResourceGeneric(ns, r, cardMap);
            var file = Path.Combine(outDir, $"{r}.g.cs");
            writeFile(file, src, dry);

            var fluentSrc = gen.BuildFluentExtensions(ns, r, cardMap);
            var fluentFile = Path.Combine(outDir, $"{r}.Fluent.g.cs");
            writeFile(fluentFile, fluentSrc, dry);

            sw.Stop();
            Console.WriteLine($"[CodeGen] {i+1}/{totalCount} Done {r} in {sw.ElapsedMilliseconds} ms");
        }
    }
}

