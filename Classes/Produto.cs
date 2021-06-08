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

        public Produto(int IDcodigo, Usuario usuario)
        {
            Codigo = IDcodigo;
            Console.WriteLine("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o preco do produto: ");
            Preco = float.Parse(Console.ReadLine());
            DataCadastro = DateTime.Now;
            CadastradoPor = usuario;
            IDcodigo++;
        }

        public string Cadastrar(Produto produto)
        {
            ListaDeProdutos.Add(produto);
            return "Produto Cadastrado!";
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "Produto deletado!";
        }

        public void Listar()
        {
            Console.WriteLine("Produtos cadastrados:");
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}, Nome do produto: {item.NomeProduto}, Preço: {item.Preco}, Data de cadastro: {item.DataCadastro}, Marca: {item.marca}, Cadastrado Por: {item.CadastradoPor}");
            }
        }
    }
}