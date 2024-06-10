namespace apbd_kol2ef_rev2.Entities
{
    public class Utwor
    {
        public int IdUtwor { get; set; }
        public string NazwaUtworu { get; set; } = null!;
        public float CzasTrwania { get; set; }
        public int? IdAlbum { get; set; }
        public virtual Album? Album { get; set; }
        public virtual ICollection<WykonawcaUtworu> WykonawcyUtwory { get; set; } = new List<WykonawcaUtworu>();
    }
}