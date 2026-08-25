namespace Fhir.Dashboard.Services;

public sealed class LocaleState
{
    public static readonly string[] Supported = ["zh-TW", "en", "ja"];

    public string Locale { get; private set; } = "zh-TW";

    public event Action? Changed;

    public void Set(string locale)
    {
        if (!Supported.Contains(locale, StringComparer.OrdinalIgnoreCase))
            return;
        if (string.Equals(Locale, locale, StringComparison.OrdinalIgnoreCase))
            return;
        Locale = locale;
        Changed?.Invoke();
    }
}
