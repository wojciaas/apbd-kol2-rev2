namespace apbd_kol2ef_rev2.Entities
{
    public class Wytwornia
    {
        public int IdWytwornia { get; set; }
        public string Nazwa { get; set; } = null!;
        public virtual ICollection<Album> Albumy { get; set; } = new List<Album>();
    }
}