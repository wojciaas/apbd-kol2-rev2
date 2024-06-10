namespace apbd_kol2ef_rev2.Entities
{
    public class WykonawcaUtworu
    {
        public int IdMuzyk { get; set; }
        public virtual Muzyk MuzykNavigation { get; set; } = null!;
        public int IdUtwor { get; set; }
        public virtual Utwor UtworNavigation { get; set; } = null!;
    }
}