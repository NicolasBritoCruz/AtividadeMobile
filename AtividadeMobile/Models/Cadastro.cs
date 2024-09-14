using SQLite;

namespace AtividadeMobile.Models
{
    public class Cadastro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Nome { get; set; } = string.Empty;

        [NotNull]
        public string Sobrenome { get; set; } = string.Empty;

        [NotNull, Unique]
        public string Email { get; set; } = string.Empty;

        [NotNull]
        public string Senha { get; set; } = string.Empty;
    }
}
