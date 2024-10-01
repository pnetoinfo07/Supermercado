using Dapper;
using System.Data.SQLite;

namespace TrabalhoFinal._02_Repository.Data
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Supermercado.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Produtos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Preco REAL NOT NULL
                );";

                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Usuarios(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Username TEXT NOT NULL,
                 Senha TEXT NOT NULL,
                 Email TEXT NOT NULL
                );";    

                 commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Carrinhos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 ProdutoId INTEGER NOT NULL,
                 UsuarioId INTEGER NOT NULL
                 );";           
                
                commandoSQL += @"   
                 CREATE TABLE IF NOT EXISTS Enderecos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Rua  TEXT NOT NULL,
                 Bairro   TEXT NOT NULL,
                 Numero  INTEGER NOT NULL,
                 UsuarioID  INTEGER NOT NULL
                 );";

                connection.Execute(commandoSQL);
            }
        }
    }
}
