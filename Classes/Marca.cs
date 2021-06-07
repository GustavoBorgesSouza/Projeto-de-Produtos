using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;


namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca : IMarca
    {
        public int codigo{get; set;}
        public string NomeMarca{get; set;}
        public DateTime DataCadastro{get; set;}

        List<Marca> listaMarcas = new List<Marca>();

        public string Cadastrar(Marca marcaCadastrar)
        {
            listaMarcas.Add(marcaCadastrar);
            return "Marca Cadastrada";
        }

        public string Deletar(Marca marcaDeletar)
        {
            listaMarcas.Remove(marcaDeletar);
            return "Marca deletada";
        }

        public void Listar()
        {
            Console.WriteLine("Aqui está a listagem de marcas");
            foreach (Marca item in listaMarcas)
            {
                Console.WriteLine($"codigo {item.codigo}, nome da marca: {item.NomeMarca} e data de cadastro: {item.DataCadastro}");
            }
        }
    }
}