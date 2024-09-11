using Cadastro_cliente.Data;

namespace Cadastro_cliente
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            var conexao = DALCliente.DbConnection();

            // Verifica se a conexão foi estabelecida com sucesso
            if (conexao != null)
            {
                Console.WriteLine("Conexão foi estabelecida corretamente no Program.");
            }
            else
            {
                Console.WriteLine("Houve um problema ao tentar estabelecer a conexão no Program.");
            }*/
            
            
            DALCliente.RemoverCliente();
        }
    }
}
