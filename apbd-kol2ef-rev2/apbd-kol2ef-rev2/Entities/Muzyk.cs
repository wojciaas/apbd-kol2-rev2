namespace apbd_kol2ef_rev2.Entities
{
    public class Muzyk
    {
        public int IdMuzyk { get; set; }
        public string Imie { get; set; } = null!;
        public string Nazwisko { get; set; } = null!;
        public string? Pseudonim { get; set; }
        public virtual ICollection<WykonawcaUtworu> WykonawcyUtwory { get; set; } = new List<WykonawcaUtworu>();
    }
}