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
            Marca m = new Marca();
            Produto p = new Produto();
            Console.WriteLine("\n Vamos te cadastrar");

            Usuario u = new Usuario(IDuser);

            Console.WriteLine(u.Cadastrar(u));

            while (logado == false)
            {
                Console.WriteLine(Logar(u));
            }


            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($@"
                 Estamos no sistema, o que você deseja fazer?

            1 - Cadastrar marca
            2 - listar marcas
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
                        Marca marca = new Marca(IDmarca);
                        Console.WriteLine(m.Cadastrar(marca));
                        i++;
                        IDmarca++;

                        logado = true;
                        break;

                    case "2":
                        m.Listar();
                        logado = true;
                        break;

                    case "3":
                        Console.WriteLine("Qual marca você deseja deletar?");
                        string marcaDel = Console.ReadLine();
                        List<Marca> procurarMarcas = m.ListarExistentes();

                        Marca encontrada = procurarMarcas.Find(item => item.NomeMarca == marcaDel);

                        Console.WriteLine(m.Deletar(encontrada));

                        logado = true;
                        break;
                    case "4":
                        Produto produto = new Produto(IDproduto, u, m.ListarExistentes());
                        if (p.Cadastrar(produto, m.ListarExistentes(), IDproduto) == "\n Produto Cadastrado!")
                        {
                            IDproduto++;
                        }

                        logado = true;
                        break;

                    case "5":
                        p.Listar();
                        logado = true;
                        break;
                    case "6":
                        Console.WriteLine("Qual produto você deseja deletar?");
                        string produtoDel = Console.ReadLine();
                        List<Produto> procurarProdutos = p.ListarExistentes();

                        Produto encontrado = procurarProdutos.Find(item => item.NomeProduto == produtoDel);

                        Console.WriteLine(p.Deletar(encontrado));

                        logado = true;

                        break;
                    case "7":
                        Console.Write(Deslogar(u));
                        break;
                    default:
                        logado = true;
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