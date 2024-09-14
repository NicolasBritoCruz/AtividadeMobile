using AtividadeMobile.Models;
using SQLite;

namespace AtividadeMobile
{
    class DataBaseContext
    {
        private const string DB_NAME = "cadastros.db3";
        private readonly string dbPath = Path.Combine(FileSystem.AppDataDirectory, DB_NAME);
        public SQLiteConnection connection { get; }

        public DataBaseContext()
        {
           connection = new SQLiteConnection(dbPath);
           connection.CreateTable<Cadastro>();
        }

    }
}
