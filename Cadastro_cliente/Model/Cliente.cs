using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_cliente.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Cliente (int id, string nome, string endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}
