using GerenciamentoBiblioteca.Classes;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new();

        while (true)
        {
            // menu principal
            Console.Clear();
            Console.WriteLine("========== BIBLIOTECA ANHEMBI ==========");
            Console.WriteLine("1. Gerenciar Livros");
            Console.WriteLine("2. Gerenciar Usuários");
            Console.WriteLine("3. Empréstimos");
            Console.WriteLine("4. Relatórios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MenuLivros(biblioteca);
                    break;

                case "2":
                    MenuUsuarios(biblioteca);
                    break;

                case "3":
                    MenuEmprestimos(biblioteca);
                    break;

                case "4":
                    biblioteca.ListarEmprestimos();
                    Console.WriteLine("Pressione Enter para voltar...");
                    Console.ReadLine();
                    break;

                case "0":
                    Console.WriteLine("Encerrando sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    // menu para gerenciar livros
    static void MenuLivros(Biblioteca biblioteca)
    {
        Console.Clear();
        Console.WriteLine("---- GERENCIAR LIVROS ----");
        Console.WriteLine("1. Cadastrar novo livro");
        Console.WriteLine("2. Listar livros disponíveis");
        Console.Write("Opção: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                // case para inserir informações do livro e cadastrar
                Console.Write("Título: ");
                var titulo = Console.ReadLine();

                Console.Write("Autor: ");
                var autor = Console.ReadLine();

                Console.Write("Ano: ");
                var ano = int.Parse(Console.ReadLine());

                Console.Write("Código do livro: ");
                var codigo = Console.ReadLine();

                biblioteca.CadastrarLivro(new Livro(titulo, autor, ano, codigo));
                Console.WriteLine("Livro cadastrado com sucesso.");
                break;

            case "2":
                // cria e mostra uma lista apenas dos livros disponíveis
                biblioteca.ListarLivrosDisponiveis();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("Pressione Enter para voltar ao menu principal...");
        Console.ReadLine();
    }

    // menu de gerenciamento de usuários
    static void MenuUsuarios(Biblioteca biblioteca)
    {
        Console.Clear();
        Console.WriteLine("---- GERENCIAR USUÁRIOS ----");
        Console.WriteLine("1. Cadastrar Aluno");
        Console.WriteLine("2. Cadastrar Professor");
        Console.WriteLine("3. Listar todos os usuários");
        Console.Write("Opção: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                // realiza o cadastro do aluno
                Console.Write("Nome: ");
                var nomeA = Console.ReadLine();

                Console.Write("ID: ");
                var idA = Console.ReadLine();

                Console.Write("Curso: ");
                var curso = Console.ReadLine();

                Console.Write("Matrícula: ");
                var matricula = Console.ReadLine();

                biblioteca.CadastrarUsuario(new Aluno(nomeA, idA, curso, matricula));
                break;

            case "2":
                // realiza o cadastro do professor
                Console.Write("Nome: ");
                var nomeP = Console.ReadLine();

                Console.Write("ID: ");
                var idP = Console.ReadLine();

                Console.Write("Departamento: ");
                var depto = Console.ReadLine();

                Console.Write("Registro: ");
                var registro = Console.ReadLine();

                biblioteca.CadastrarUsuario(new Professor(nomeP, idP, depto, registro));
                break;

            case "3":
                // cria uma lista de todos os usuários cadastrados
                biblioteca.ListarUsuarios();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("Pressione Enter para voltar ao menu principal...");
        Console.ReadLine();
    }

    // menu para registrar empréstimos e devoluções
    static void MenuEmprestimos(Biblioteca biblioteca)
    {
        Console.Clear();
        Console.WriteLine("---- EMPRÉSTIMOS ----");
        Console.WriteLine("1. Emprestar livro");
        Console.WriteLine("2. Devolver livro");
        Console.Write("Opção: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                // dados para realizar empréstimo
                Console.Write("ID do usuário: ");
                var idUser = Console.ReadLine();

                Console.Write("Código do livro: ");
                var codigoLivro = Console.ReadLine();

                biblioteca.EmprestarLivro(idUser, codigoLivro);
                break;

            case "2":
                // código do livro para devolução
                Console.Write("Código do livro a devolver: ");
                var codigoDev = Console.ReadLine();

                biblioteca.DevolverLivro(codigoDev);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("Pressione Enter para voltar ao menu principal...");
        Console.ReadLine();
    }
}
