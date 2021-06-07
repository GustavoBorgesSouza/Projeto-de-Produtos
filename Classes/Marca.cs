using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;


namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Marca : IMarca
    {
        List<Marca> listaMarcas = new List<Marca>();

        public string Cadastrar(Marca marcaCadastrar)
        {
            return "llll";  //só pra não dar erro de return
        }

        public string Deletar(Marca marcaDeletar)
        {
            return "llll"; //só para não dar erro de return
        }

        public void Listar()
        {
            
        }
    }
}