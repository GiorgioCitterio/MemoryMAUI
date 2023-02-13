using SQLite;

namespace _00_MemoryGiorgioCitterio.Model
{
    public enum Tema
    {
        Arte,
        Supereroi,
        Frutta,
        Citta
    }
    public enum Difficolta
    {
        Facile,
        Medio,
        Difficile
    }
    [Table("Dati")]
    public class Dati
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int MosseImpiegate { get; set; }
        public TimeSpan TempoImpiegato { get; set; }
        public Tema Tema { get; set; }
        public Difficolta Difficolta { get; set; }
    }
}
