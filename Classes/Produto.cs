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

        public Produto(int IDcodigo, Usuario usuario, Marca marca)
        {
            Codigo = IDcodigo;
            Console.WriteLine("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("\nDigite o preco do produto em reais: ");
            Preco = float.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;
            CadastradoPor = usuario.Nome;
            Marca = marca.NomeMarca;
            IDcodigo++;
        }

        public string Cadastrar(Produto produto, List<Marca> ListaMarcas)
        {
            if (ListaMarcas.Count > 0)
            {
                ListaDeProdutos.Add(produto);
                return "\nProduto Cadastrado!";
            }

            else
            {
                return "Não é possível cadastrar um produto se não há marca";
            }
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "\nProduto deletado!";
        }

        public void Listar()
        {
            Console.WriteLine("\nProdutos cadastrados: ");

            if (ListaDeProdutos.Count > 0)
            {
                foreach (Produto item in ListaDeProdutos)
                {
                    Console.WriteLine($"Código: {item.Codigo}, Nome do produto: {item.NomeProduto}, Preço: {item.Preco}, Data de cadastro: {item.DataCadastro}, Marca: {item.marca}, Cadastrado Por: {item.CadastradoPor}");
                }
            }

            else
            {
                Console.WriteLine("A lista está vazia!!!");
            }
        }

        public List<Produto> ListarExistentes()
        {
            return ListaDeProdutos;
        }
    }
}