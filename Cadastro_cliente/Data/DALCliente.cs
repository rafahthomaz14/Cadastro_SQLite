using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_cliente.Data
{
    public class DALCliente
    {
        private static SQLiteConnection sqLiteConnection;

        public static string path = Directory.GetCurrentDirectory() + "\\cadastro.db";


        public static SQLiteConnection DbConnection()
        {
            sqLiteConnection = new SQLiteConnection("Data Source=" + path);
            sqLiteConnection.Open();
            return sqLiteConnection;

        }

        public static void AdicionarCliente()
        {
            try
            {
                Console.WriteLine("Digite o ID do cliente:");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o Npme do cliente:");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite o Endereço do cliente:");
                string Endereco = Console.ReadLine();


                using (var comando = DbConnection().CreateCommand())
                {
                    comando.CommandText = "INSERT INTO Clientes (Id,Nome,Endereco) VALUES (@id,@nome,@endereco)";
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@endereco", Endereco);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        Console.WriteLine("Cliente Cadastrado com Sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Erro cliente nao cadastrado");
                    }
                }
            }catch (SQLiteException ex)
            {
                Console.WriteLine("ERRO BANCO DE DADOS");
            }
        }


        public static void RemoverCliente()
        {
            try
            {
                Console.WriteLine("Digite o Id do Cliente:");
                int Id = Convert.ToInt32(Console.ReadLine());

                using (var comando = DbConnection().CreateCommand())
                {
                    comando.CommandText = "DELETE FROM Clientes WHERE Id = @id";
                    comando.Parameters.AddWithValue("@id", Id);

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        Console.WriteLine("Cliente removido com sucesso!");
                    }
                }
            }catch(SQLiteException ex)
            {
                Console.WriteLine("ERRO SQL");
            }
            


        }
    }
}
