var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var backend = builder.Configuration.GetValue<string>("BackendUrl") ?? "http://localhost:5000";
builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri(backend));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
