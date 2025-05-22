using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    // classe professor que vai herdar da classe usuario
    public class Professor : Usuario
    {
        public string Departamento { get; set; }
        public string Registro { get; set; }

        public Professor(string nome, string id, string departamento, string registro) : base(nome, id)
        {
            Departamento = departamento;
            Registro = registro;
        }

        // vai exibir as informações do professor
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[Professor] Nome: {Nome}, ID: {ID}, Departamento: {Departamento}, Registro: {Registro}");
        }
    }
}

