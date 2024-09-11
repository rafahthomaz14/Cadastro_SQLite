using Cadastro_cliente.Data;
using Cadastro_cliente.Model;
using System;
using System.Collections.Generic;
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

            //DALCliente.AdicionarCliente();
            //DALCliente.RemoverCliente();

            ExibirCliente();

        }

        public static void ExibirCliente()
        {
            //para exibir os resultados da consulta SQL
            List<Cliente> Clientes = DALCliente.ListaCliente();
            foreach (Cliente cliente in Clientes)
            {
                Console.WriteLine("Id: {0}", cliente.Id);
                Console.WriteLine("Nome: {0}", cliente.Nome);
                Console.WriteLine("Eendereço: {0}", cliente.Endereco);

                Console.WriteLine();


            }
        }

    }
}

 