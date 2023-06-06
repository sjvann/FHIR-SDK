
using CdsServices;
using Core.CdsHooks;
using FHIRServer;

string corsName = "cds";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{

    options.AddPolicy(corsName, policy =>
    {
        policy.WithOrigins("https://localhost:7016", "https://sandbox.cds-hooks.org","http://sandbox.cds-hooks.org").AllowAnyHeader().AllowAnyMethod();

    });
});


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IPrefetchService, PrefetchService>();
builder.Services.AddSingleton<IResponseService, ResponseService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(corsName);
app.UseHttpsRedirection();
app.UseCdsServiceApi();

app.Run();

