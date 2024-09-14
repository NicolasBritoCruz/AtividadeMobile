using SQLite;
using AtividadeMobile.Models;
using System.Collections.Generic;

namespace AtividadeMobile.Repositories
{
    public class CadastroRepository
    {
        private readonly SQLiteConnection connection;
        //CRUD
        public CadastroRepository()
        {
            connection = new DataBaseContext().connection;
        }

        public void Create(Cadastro cadastro)
        {
            connection.Insert(cadastro);
        }

        public List<Cadastro> Read()
        {
            return connection.Table<Cadastro>().ToList();
        }

        public void Update(Cadastro cadastro)
        {
            connection.Update(cadastro);
        }

        public void Delete(Cadastro cadastro)
        {
            connection.Delete(cadastro);
        }

    }
}
