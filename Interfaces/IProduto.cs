using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IProduto
    {
         string Cadastrar(Marca produtoCadastrar);

         void Listar();

         string Deletar(Marca produtoDeletar);
    }
}