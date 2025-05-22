using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    public class Emprestimo
    {
        public Usuario Usuario { get; }
        public Livro Livro { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime? DataDevolucao { get; private set; }
        public bool Ativo { get; private set; } = true;

        // inicia o empréstimo e marca o livro como emprestado
        public Emprestimo(Usuario usuario, Livro livro)
        {
            Usuario = usuario;
            Livro = livro;
            DataEmprestimo = DateTime.Now;
            livro.MarcarComoEmprestado();
        }

        // irá marcar o empréstimo como devolvido
        public void RegistrarDevolucao()
        {
            if (!Ativo)
                return;

            DataDevolucao = DateTime.Now;
            Livro.MarcarComoDevolvido();
            Ativo = false;
        }

        // vai mostrar um resumo com as informações do empréstimo
        public void ExibirResumo()
        {
            string status = Ativo
                ? "Ativo"
                : $"Concluído em {DataDevolucao?.ToString("g")}";

            Console.WriteLine(
                $"Usuário : {Usuario.Nome} | " +
                $"Livro : {Livro.Titulo} | " +
                $"Empréstimo : {DataEmprestimo:g} | " +
                $"Status : {status}"
            );
        }
    }
}

