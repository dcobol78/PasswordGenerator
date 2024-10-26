using WebApp.Components;
using WebApp.Services;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Infrastructure;
using Infrastructure.Data;
using ApplicationCore.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

if (builder.Environment.IsDevelopment())
{
    // Использовать SQL Server (local)
    Infrastructure.Dependencies.ConfigureServices(builder.Configuration, builder.Services);
}

// Разделить сервисы на core и web
//core
builder.Services.AddScoped<IPasswordService ,PasswordService>();
builder.Services.AddScoped(typeof(IRepository<Password>), typeof(EFRepository));

//web
builder.Services.AddScoped<IClipboardService, ClipboardService>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
