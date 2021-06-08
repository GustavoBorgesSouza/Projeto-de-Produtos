using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IProduto
    {
        string Cadastrar(Produto produto, List<Marca> ListaMarcas);

        void Listar();

        string Deletar(Produto produtoDeletar);
    }
}