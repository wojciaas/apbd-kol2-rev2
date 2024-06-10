using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apbd_kol2ef_rev2.Entities.Configs
{
    public class WytworniaEfConfig : IEntityTypeConfiguration<Wytwornia>
    {
        public void Configure(EntityTypeBuilder<Wytwornia> builder)
        {
            builder.HasKey(w => w.IdWytwornia);
            builder.Property(w => w.IdWytwornia).ValueGeneratedNever();
            builder.Property(w => w.Nazwa).HasMaxLength(50).IsRequired();

            builder.HasData(
                new Wytwornia {IdWytwornia = 1, Nazwa = "Universal Music Group"},
                new Wytwornia {IdWytwornia = 2, Nazwa = "Sony Music Entertainment"},
                new Wytwornia {IdWytwornia = 3, Nazwa = "Warner Music Group"}
                );
            
            builder.ToTable("Wytwornia");
        }
    }
}