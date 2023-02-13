using _00_MemoryGiorgioCitterio.Model;
using SQLite;

namespace _00_MemoryGiorgioCitterio
{
    public class DatiRepository
    {
        string _dbPath;
        private SQLiteAsyncConnection connection;

        public DatiRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task Init()
        {
            if (connection != null)
            {
                return;
            }
            connection = new SQLiteAsyncConnection(_dbPath);
            await connection.CreateTableAsync<Dati>();
        }

        public async Task AddPartita(Dati dato)
        {
            int result = default;
            try
            {
                await Init();
                result = await connection.InsertAsync(new Dati() { Data = dato.Data, MosseImpiegate = dato.MosseImpiegate, TempoImpiegato = dato.TempoImpiegato, Tema = dato.Tema, Difficolta = dato.Difficolta});
            }
            catch (Exception) { }
        }

        public async Task<List<Dati>> GetAllPartite()
        {
            try
            {
                await Init();
                var lista = await connection.Table<Dati>().ToListAsync();
                return lista;
            }
            catch (Exception) { }
            return new List<Dati>();
        }
    }
}
