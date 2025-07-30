using Microsoft.EntityFrameworkCore;

namespace TasteWhiskyApi.Models;

public class TasteWhiskyContext : DbContext
{
    public TasteWhiskyContext(DbContextOptions<TasteWhiskyContext> options)
        : base(options)
    {
    }

    public DbSet<Distillery> Distilleries => Set<Distillery>();
    public DbSet<Dram> Drams => Set<Dram>();
    public DbSet<TastingNote> TastingNotes => Set<TastingNote>();
    public DbSet<User> Users => Set<User>();
}
