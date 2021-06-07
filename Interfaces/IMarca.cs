using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IMarca
    {
         string Cadastrar(Marca marcaCadastrar);

         void Listar();

         string Deletar(Marca marcaDeletar);
    }
}