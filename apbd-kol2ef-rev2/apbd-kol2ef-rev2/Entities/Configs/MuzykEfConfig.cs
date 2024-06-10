using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_kol2ef_rev2.Entities.Configs
{
    public class MuzykEfConfig : IEntityTypeConfiguration<Muzyk>
    {
        public void Configure(EntityTypeBuilder<Muzyk> builder)
        {
            builder.HasKey(m => m.IdMuzyk);
            builder.Property(m => m.IdMuzyk).ValueGeneratedNever();
            builder.Property(m => m.Imie).HasMaxLength(30).IsRequired();
            builder.Property(m => m.Nazwisko).HasMaxLength(40).IsRequired();
            builder.Property(m => m.Pseudonim).HasMaxLength(50);

            builder.HasData(
                new Muzyk
                {
                    IdMuzyk = 1,
                    Imie = "Jan",
                    Nazwisko = "Kowalski",
                    Pseudonim = "Kowal"
                },
                new Muzyk
                {
                    IdMuzyk = 2,
                    Imie = "Anna",
                    Nazwisko = "Nowak",
                    Pseudonim = "Nowa"
                },
                new Muzyk
                {
                    IdMuzyk = 3,
                    Imie = "Piotr",
                    Nazwisko = "Wiśniewski",
                    Pseudonim = "Wiśnia"
                }
                );
            
            builder.ToTable("Muzyk");
        }
    }
}