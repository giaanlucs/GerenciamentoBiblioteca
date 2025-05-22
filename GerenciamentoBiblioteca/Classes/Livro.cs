using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Codigo { get; set; } // esse código seria o ID do Livro
        public bool Disponivel { get; private set; } = true;

        public Livro(string titulo, string autor, int ano, string codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Codigo = codigo;
        }

        public void MarcarComoEmprestado() => Disponivel = false;
        public void MarcarComoDevolvido() => Disponivel = true;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Ano: {Ano} | Código: {Codigo} | Disponível: {Disponivel}");
        }
    }
}
