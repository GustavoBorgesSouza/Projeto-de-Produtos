using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;


namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca : IMarca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> listaMarcas = new List<Marca>();

        public Marca(){}

        public Marca(int IDmarca)
        {
            Codigo = IDmarca;
            Console.WriteLine("Qual o nome da marca?");
            NomeMarca = Console.ReadLine();
            DataCadastro = DateTime.Now;
        }

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
            if (listaMarcas.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                foreach (Marca item in listaMarcas)
                {
                    Console.WriteLine($"codigo {item.Codigo}, nome da marca: {item.NomeMarca} e data de cadastro: {item.DataCadastro}");
                }
            } else{
                Console.WriteLine("lista vazia");
            }
            Console.ResetColor();
        }

        public List<Marca> ListarExistentes(){
            return listaMarcas;
        }
    }
}