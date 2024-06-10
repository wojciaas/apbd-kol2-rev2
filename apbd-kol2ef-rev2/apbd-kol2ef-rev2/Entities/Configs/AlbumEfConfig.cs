using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_kol2ef_rev2.Entities.Configs
{
    public class AlbumEfConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(a => a.IdAlbum);
            builder.Property(a => a.IdAlbum).ValueGeneratedNever();
            builder.Property(a => a.NazwaAlbumu).HasMaxLength(30).IsRequired();
            builder.Property(a => a.DataWydania).HasColumnType("datetime").IsRequired();
            builder.HasOne(a => a.WytworniaNavigation)
                .WithMany(w => w.Albumy)
                .HasForeignKey(a => a.IdWytwornia)
                .HasConstraintName("Album_Wytwornia")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Album
                {
                    IdAlbum = 1,
                    NazwaAlbumu = "Album1",
                    DataWydania = new DateTime(2020, 1, 1),
                    IdWytwornia = 1
                },
                new Album
                {
                    IdAlbum = 2,
                    NazwaAlbumu = "Album2",
                    DataWydania = new DateTime(2020, 2, 1),
                    IdWytwornia = 2
                },
                new Album
                {
                    IdAlbum = 3,
                    NazwaAlbumu = "Album3",
                    DataWydania = new DateTime(2020, 3, 1),
                    IdWytwornia = 3
                }
                );

            builder.ToTable("Album");
        }
    }
}