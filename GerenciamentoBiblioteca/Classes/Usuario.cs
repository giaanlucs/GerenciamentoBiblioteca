using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string ID { get; set; }

        public Usuario(string nome, string id)
        {
            Nome = nome;
            ID = id;
        }

        public abstract void ExibirInformacoes();
    }
}
