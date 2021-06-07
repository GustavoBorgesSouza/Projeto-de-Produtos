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
        public string Cadastrar(Produto produtoCadastrar)
        {
            ListaDeProdutos.Add(produtoCadastrar);
            return "Produto Cadastrado";
        }

        public string Deletar(Produto produtoDeletar)
        {
            ListaDeProdutos.Remove(produtoDeletar);
            return "Produto deletado";
        }

        public void Listar()
        {
            Console.WriteLine("Produtos cadastrados: ");
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}, Nome do produto: {item.NomeProduto}, Preço: {item.Preco}, Data de cadastro: {item.DataCadastro}, Marca: {item.marca}, Cadastrado Por: {item.CadastradoPor}");
            }
        }
    }
}