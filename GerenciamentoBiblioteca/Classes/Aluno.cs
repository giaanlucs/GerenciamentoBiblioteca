using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    public class Aluno : Usuario
    {
        public string Curso { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome, string id, string curso, string matricula)
            : base(nome, id)
        {
            this.Curso = curso;
            this.Matricula = matricula;
        }
        // define que o metodo do aluno será usado para exibir
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[Aluno]");
            Console.WriteLine($"Nome     : {Nome}");
            Console.WriteLine($"ID       : {ID}");
            Console.WriteLine($"Curso    : {Curso}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }
}
