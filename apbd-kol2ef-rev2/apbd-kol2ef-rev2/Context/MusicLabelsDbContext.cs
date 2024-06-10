using apbd_kol2ef_rev2.Entities;
using Microsoft.EntityFrameworkCore;

namespace apbd_kol2ef_rev2.Context;

public class MusicLabelsDbContext : DbContext
{
    public virtual DbSet<Album> Albumy { get; set; }
    public virtual DbSet<Muzyk> Muzycy { get; set; }
    public virtual DbSet<Utwor> Utwory { get; set; }
    public virtual DbSet<WykonawcaUtworu> WykonawcyUtworow { get; set; }
    public virtual DbSet<Wytwornia> Wytwornie { get; set; }
    
    protected MusicLabelsDbContext()
    {
    }

    public MusicLabelsDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MusicLabelsDbContext).Assembly);
    }
}