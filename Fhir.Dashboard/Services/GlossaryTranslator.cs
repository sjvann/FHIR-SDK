namespace Fhir.Dashboard.Services;

public sealed class GlossaryTranslator : ISpecTranslator
{
    private readonly GlossaryStore _store;

    public GlossaryTranslator(GlossaryStore store) => _store = store;

    public bool HasGlossary(string fhirName) => _store.Has(fhirName);

    public TranslatedText Resolve(string fhirName, string locale)
    {
        if (_store.TryGet(fhirName, out var entry))
        {
            var label = locale switch
            {
                "ja" => entry.Ja,
                "en" => entry.En,
                _ => entry.ZhTw
            };
            var summary = locale switch
            {
                "ja" => entry.JaSummary,
                "en" => entry.EnSummary,
                _ => entry.ZhTwSummary
            };
            return new TranslatedText(label, summary, TranslationSource.Glossary);
        }

        return new TranslatedText(fhirName, null, TranslationSource.Pending);
    }
}
