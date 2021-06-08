using System;
using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int IDcodigo = 1;
            Usuario usuario = new Usuario();
            Marca marca = new Marca();
            Produto produto = new Produto(IDcodigo, usuario, marca);

            produto.Cadastrar(produto);
            produto.Listar();
            produto.Deletar(produto);

        }
    }
}
