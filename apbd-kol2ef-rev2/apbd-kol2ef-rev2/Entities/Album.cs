namespace apbd_kol2ef_rev2.Entities
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string NazwaAlbumu { get; set; } = null!;
        public DateTime DataWydania { get; set; }
        public int IdWytwornia { get; set; }
        public virtual Wytwornia WytworniaNavigation { get; set; } = null!;
        public virtual ICollection<Utwor> Utwory { get; set; } = new List<Utwor>();
    }
}