using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : ILogin
    {
        public bool logado;

        public Login()
        {
            int IDuser = 1;
            int IDmarca = 1;
            int IDproduto = 1;
            int i = 0;

            Marca m = new Marca(); //Objeto pai
            Produto p = new Produto(); //Objeto pai

            Console.WriteLine("\n Vamos te cadastrar");

            Usuario u = new Usuario(IDuser);

            Console.WriteLine(u.Cadastrar(u));

            while (logado == false)
            {
                Console.WriteLine(Logar(u));
            }


            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($@"
                 Estamos no sistema, o que você deseja fazer?

            1 - Cadastrar marca
            2 - Listar marcas
            3 - Deletar marca
            4 - Cadastrar produtos
            5 - Listar produtos
            6 - Deletar produtos
            7 - Sair");

                Console.ResetColor();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Marca marca = new Marca(IDmarca); //Cria a marca pedindo o que é necessário

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(m.Cadastrar(marca)); //Adiciona a marca a lista do objeto pai
                        Console.ResetColor();
                        i++;
                        IDmarca++;
                        break;

                    case "2":
                        m.Listar();
                        break;

                    case "3":
                        Console.WriteLine("Qual marca você deseja deletar?");
                        string marcaDel = Console.ReadLine();
                        List<Marca> procurarMarcas = m.ListarExistentes();

                        Marca encontrada = procurarMarcas.Find(item => item.NomeMarca == marcaDel);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(m.Deletar(encontrada));
                        Console.ResetColor();
                        break;

                    case "4":
                        Produto produto = new Produto(IDproduto, u, m.ListarExistentes());
                        if (p.Cadastrar(produto, m.ListarExistentes(), IDproduto) == "\n Produto Cadastrado!") //Cria um produto e verifica se a marca existe
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Produto cadastrado com sucesso!");
                            IDproduto++;
                            Console.ResetColor();
                        }
                        break;

                    case "5":
                        p.Listar();
                        break;

                    case "6":
                        Console.WriteLine("Qual produto você deseja deletar?");
                        string produtoDel = Console.ReadLine();
                        List<Produto> procurarProdutos = p.ListarExistentes();

                        Produto encontrado = procurarProdutos.Find(item => item.NomeProduto == produtoDel);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(p.Deletar(encontrado));
                        Console.ResetColor();
                        break;

                    case "7":
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(Deslogar(u));
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Essa não é uma das opções validas, digite uma válida");
                        Console.ResetColor();
                        break;
                }

            } while (logado == true);




        }

        public string Deslogar(Usuario user)
        {
            logado = false;
            return "Saindo do sistema";
        }

        public string Logar(Usuario user)
        {
            Console.WriteLine("\n Digite seu nome");
            string nomeDigitado = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            string senhaDigitada = Console.ReadLine();

            if (user.Nome == nomeDigitado && user.Senha == senhaDigitada)
            {
                logado = true;
                return "Você pode entrar no sistema";
            }
            else
            {
                logado = false;
                return "Você digitou algo errado, os dados não condizem com os do sistema";
            }

        }
    }
}