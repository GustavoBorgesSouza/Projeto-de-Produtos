using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Produto : IProduto
    {
        List<Produto> produtos = new List<Produto>();

        public Produto(){}
        public string Cadastrar(Marca produtoCadastrar)
        {
            return "llll"; //só para não dar erro de return
        }

        public string Deletar(Marca produtoDeletar)
        {
            return "llll"; //só para não dar erro de return
        }

        public void Listar()
        {
            
        }
    }
}