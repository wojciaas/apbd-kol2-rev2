using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_kol2ef_rev2.Entities.Configs
{
    public class WykonawcaUtworEfConfig : IEntityTypeConfiguration<WykonawcaUtworu>
    {
        public void Configure(EntityTypeBuilder<WykonawcaUtworu> builder)
        {
            builder.HasKey(wu => new { wu.IdMuzyk, wu.IdUtwor });
            builder.HasOne(wu => wu.MuzykNavigation)
                .WithMany(m => m.WykonawcyUtwory)
                .HasForeignKey(wu => wu.IdMuzyk)
                .HasConstraintName("WykonawcaUtworu_Muzyk")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(wu => wu.UtworNavigation)
                .WithMany(u => u.WykonawcyUtwory)
                .HasForeignKey(wu => wu.IdUtwor)
                .HasConstraintName("WykonawcaUtworu_Utwor")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new WykonawcaUtworu { IdMuzyk = 1, IdUtwor = 1 },
                new WykonawcaUtworu { IdMuzyk = 2, IdUtwor = 2 },
                new WykonawcaUtworu { IdMuzyk = 3, IdUtwor = 3 },
                new WykonawcaUtworu { IdMuzyk = 1, IdUtwor = 4 },
                new WykonawcaUtworu { IdMuzyk = 1, IdUtwor = 5 },
                new WykonawcaUtworu { IdMuzyk = 2, IdUtwor = 6 },
                new WykonawcaUtworu { IdMuzyk = 3, IdUtwor = 6 }
                );

            builder.ToTable("WykonawcaUtworu");
        }
    }
}