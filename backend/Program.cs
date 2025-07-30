using Microsoft.EntityFrameworkCore;
using TasteWhiskyApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TasteWhiskyContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<TasteWhiskyContext>();
    db.Database.EnsureCreated();
    DataSeeder.Seed(db);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/distilleries", async (TasteWhiskyContext db) =>
    await db.Distilleries.ToListAsync());

app.MapGet("/api/drams", async (TasteWhiskyContext db) =>
    await db.Drams.Include(d => d.Distillery).ToListAsync());

app.MapGet("/api/tastingnotes", async (TasteWhiskyContext db) =>
    await db.TastingNotes
        .Include(n => n.Dram)
        .Include(n => n.User)
        .ToListAsync());

app.Run();
