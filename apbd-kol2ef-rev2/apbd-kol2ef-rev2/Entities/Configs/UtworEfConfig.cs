using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_kol2ef_rev2.Entities.Configs
{
    public class UtworEfConfig : IEntityTypeConfiguration<Utwor>
    {
        public void Configure(EntityTypeBuilder<Utwor> builder)
        {
            builder.HasKey(u => u.IdUtwor);
            builder.Property(u => u.IdUtwor).ValueGeneratedNever();
            builder.Property(u => u.NazwaUtworu).HasMaxLength(30).IsRequired();
            builder.Property(u => u.CzasTrwania).HasColumnType("float").IsRequired();
            builder.HasOne(u => u.Album)
                .WithMany(a => a.Utwory)
                .HasForeignKey(u => u.IdAlbum)
                .HasConstraintName("Album_Utwor")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Utwor
                {
                    IdUtwor = 1,
                    NazwaUtworu = "Utwor1",
                    CzasTrwania = 3.5f,
                    IdAlbum = 1
                },
                new Utwor
                {
                    IdUtwor = 2,
                    NazwaUtworu = "Utwor2",
                    CzasTrwania = 4.5f,
                    IdAlbum = 1
                },
                new Utwor
                {
                    IdUtwor = 3,
                    NazwaUtworu = "Utwor3",
                    CzasTrwania = 5.5f,
                    IdAlbum = 2
                },
                new Utwor
                {
                    IdUtwor = 4,
                    NazwaUtworu = "Utwor4",
                    CzasTrwania = 6.5f,
                    IdAlbum = 2
                },
                new Utwor
                {
                    IdUtwor = 5,
                    NazwaUtworu = "Utwor5",
                    CzasTrwania = 7.5f,
                    IdAlbum = 3
                },
                new Utwor
                {
                    IdUtwor = 6,
                    NazwaUtworu = "Utwor6",
                    CzasTrwania = 8.5f,
                    IdAlbum = 3
                }
                );
            
            builder.ToTable("Utwor");
        }
    }
}