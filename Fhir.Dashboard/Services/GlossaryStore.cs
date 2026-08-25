using System.Collections.Concurrent;
using System.Text.Encodings.Web;
using System.Text.Json;
using Microsoft.Extensions.Hosting;

namespace Fhir.Dashboard.Services;

public sealed record GlossaryEntry(
    string En,
    string ZhTw,
    string Ja,
    string EnSummary,
    string ZhTwSummary,
    string JaSummary);

public sealed class GlossaryStore
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private readonly string _overlayPath;
    private readonly ConcurrentDictionary<string, GlossaryEntry> _live;
    private readonly ConcurrentDictionary<string, GlossaryEntry> _overlay;
    private readonly object _gate = new();

    public GlossaryStore(IHostEnvironment env)
    {
        var dataDir = Path.Combine(env.ContentRootPath, "data");
        Directory.CreateDirectory(dataDir);
        _overlayPath = Path.Combine(dataDir, "glossary.overlay.json");
        _overlay = new ConcurrentDictionary<string, GlossaryEntry>(LoadOverlay(), StringComparer.OrdinalIgnoreCase);
        _live = new ConcurrentDictionary<string, GlossaryEntry>(GlossarySeed.Entries, StringComparer.OrdinalIgnoreCase);
        foreach (var pair in _overlay)
            _live[pair.Key] = pair.Value;
    }

    public event Action? Changed;

    public string OverlayPath => _overlayPath;

    public bool Has(string fhirName) => _live.ContainsKey(fhirName);

    public bool IsOverlay(string fhirName) => _overlay.ContainsKey(fhirName);

    public bool TryGet(string fhirName, out GlossaryEntry entry) => _live.TryGetValue(fhirName, out entry!);

    public void Upsert(string fhirName, GlossaryEntry entry)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(fhirName);
        _live[fhirName] = entry;
        _overlay[fhirName] = entry;
        Persist();
        Changed?.Invoke();
    }

    public void Revert(string fhirName)
    {
        if (!_overlay.TryRemove(fhirName, out _))
            return;

        if (GlossarySeed.Entries.TryGetValue(fhirName, out var seed))
            _live[fhirName] = seed;
        else
            _live.TryRemove(fhirName, out _);

        Persist();
        Changed?.Invoke();
    }

    private Dictionary<string, GlossaryEntry> LoadOverlay()
    {
        if (!File.Exists(_overlayPath))
            return new Dictionary<string, GlossaryEntry>(StringComparer.OrdinalIgnoreCase);

        try
        {
            var json = File.ReadAllText(_overlayPath);
            var loaded = JsonSerializer.Deserialize<Dictionary<string, GlossaryEntry>>(json, JsonOptions);
            return loaded is null
                ? new Dictionary<string, GlossaryEntry>(StringComparer.OrdinalIgnoreCase)
                : new Dictionary<string, GlossaryEntry>(loaded, StringComparer.OrdinalIgnoreCase);
        }
        catch (JsonException)
        {
            return new Dictionary<string, GlossaryEntry>(StringComparer.OrdinalIgnoreCase);
        }
    }

    private void Persist()
    {
        lock (_gate)
        {
            var snapshot = _overlay
                .OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase)
                .ToDictionary(pair => pair.Key, pair => pair.Value, StringComparer.OrdinalIgnoreCase);
            var json = JsonSerializer.Serialize(snapshot, JsonOptions);
            File.WriteAllText(_overlayPath, json);
        }
    }
}
