using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using vivstargame;
using Microsoft.AspNetCore.SignalR;
using vivstargame.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<BrowserService>();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<List<DataManager>>();


// SignalR hub configuration
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();

app.MapHub<MainHub>("/mainhub"); // Map your custom hub endpoint

app.MapFallbackToPage("/_Host");

app.Run();
