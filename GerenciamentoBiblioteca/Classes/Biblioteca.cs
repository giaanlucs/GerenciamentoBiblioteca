using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca.Classes
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; } = new();
        public List<Usuario> Usuarios { get; } = new();
        public List<Emprestimo> Emprestimos { get; } = new();

        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        // para listar livros disponíveis
        public void ListarLivrosDisponiveis()
        {
            Console.WriteLine("\n--- Livros Disponíveis ---");
            var livrosDisponiveis = Livros.Where(l => l.Disponivel).ToList();

            if (!livrosDisponiveis.Any())
            {
                Console.WriteLine("Nenhum livro disponível no momento.");
                return;
            }

            foreach (var livro in livrosDisponiveis)
                livro.ExibirInformacoes();
        }

        // para listar usuários cadastrados
        public void ListarUsuarios()
        {
            Console.WriteLine("\n--- Usuários Cadastrados ---");

            if (!Usuarios.Any())
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            foreach (var usuario in Usuarios)
                usuario.ExibirInformacoes();
        }

        // para emprestar um livro a um usuário
        public void EmprestarLivro(string idUsuario, string codigo)
        {
            var usuario = Usuarios.Find(u => u.ID == idUsuario);
            var livro = Livros.Find(l => l.Codigo == codigo && l.Disponivel);

            if (usuario == null || livro == null)
            {
                Console.WriteLine("Usuário não encontrado ou livro indisponível.");
                return;
            }

            Emprestimos.Add(new Emprestimo(usuario, livro));
            Console.WriteLine("Empréstimo realizado com sucesso.");
        }

        // para devolver um livro
        public void DevolverLivro(string codigo)
        {
            var emprestimo = Emprestimos.Find(e => e.Livro.Codigo == codigo && e.Ativo);

            if (emprestimo != null)
            {
                emprestimo.RegistrarDevolucao();
                Console.WriteLine("Devolução registrada.");
            }
            else
            {
                Console.WriteLine("Nenhum empréstimo ativo para este livro.");
            }
        }

        // metodo para listar todos os empréstimos
        public void ListarEmprestimos()
        {
            Console.WriteLine("\n--- Histórico de Empréstimos ---");

            if (!Emprestimos.Any())
            {
                Console.WriteLine("Nenhum empréstimo registrado.");
                return;
            }

            foreach (var emprestimo in Emprestimos)
                emprestimo.ExibirResumo();
        }
    }
}
