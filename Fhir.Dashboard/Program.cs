using Fhir.Dashboard.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls(builder.Configuration["Urls"] ?? "http://localhost:5090");

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<AtlasCatalog>();
builder.Services.AddSingleton<GlossaryStore>();
builder.Services.AddSingleton<ISpecTranslator, GlossaryTranslator>();
builder.Services.AddScoped<LocaleState>();

var app = builder.Build();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapGet("/health", () => Results.Text("ok"));
app.MapGet("/api/catalog", (AtlasCatalog catalog) => Results.Json(new
{
    primitives = catalog.Primitives.Count,
    complexes = catalog.ComplexTypes.Count,
    resources = catalog.Resources.Count,
    lines = catalog.Lines.Select(line => new
    {
        line,
        count = catalog.Resources.Count(r => r.Lines.Contains(line))
    })
}));

app.MapRazorComponents<Fhir.Dashboard.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
