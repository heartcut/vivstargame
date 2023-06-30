
ill try to put the config settings and stuff here

port forwarding on router

xnginx settings

appsetting settings or something.

added builder.Services.AddScoped<BrowserService>();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<List<DataManager>>();


// SignalR hub configuration
builder.Services.AddSignalR();

app.MapBlazorHub();

app.MapHub<MainHub>("/mainhub"); // Map your custom hub endpoint

to program.cs

need to change some stuff in launch settings for port stuff?