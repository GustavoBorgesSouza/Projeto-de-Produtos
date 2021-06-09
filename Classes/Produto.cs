using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();

        public Produto(){}

        public Produto(int IDcodigo, Usuario user, List<Marca> listaMarcas)
        {
            Codigo = IDcodigo;
            Console.WriteLine("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("\nDigite o preço do produto: R$");
            Preco = float.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;

            CadastradoPor = user;
            Console.Write("Digite o nome da marca: ");
            string VerificarMarca = Console.ReadLine();
            marca = listaMarcas.Find(item => item.NomeMarca == VerificarMarca);
        }

        public string Cadastrar(Produto produto, List<Marca> listaMarcas, int IDproduto)
        {

            {
                if (listaMarcas.Count > 0 && produto.marca != null)
                {
                    ListaDeProdutos.Add(produto);
                    IDproduto++;
                    return "\n Produto Cadastrado!";
                }

                else
                {
                    return "Não é possível cadastrar um produto quando não há marcas ou a marca é inexstente";
                }
            }
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "\n Produto deletado!";
        }

        public void Listar()
        {
            Console.WriteLine("\n Produtos cadastrados: ");

            if (ListaDeProdutos.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                foreach (Produto item in ListaDeProdutos)
                {
                    Console.WriteLine($@"Código: {item.Codigo}, Nome do produto: {item.NomeProduto}, Preço: {item.Preco:C2}, Data de cadastro: {item.DataCadastro}, Marca: {item.marca.NomeMarca}, Cadastrado Por: {item.CadastradoPor.Nome}");
                }
            }

            else
            {
                Console.WriteLine("A lista está vazia!!!");
            }

            Console.ResetColor();
        }

        public List<Produto> ListarExistentes()
        {
            return ListaDeProdutos;
        }
    }
}