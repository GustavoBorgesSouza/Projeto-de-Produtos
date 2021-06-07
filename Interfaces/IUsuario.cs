using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IUsuario
    {
         string Cadastrar(Usuario userCadastrar);
         string Deletar(Usuario userDeletar);
    }
}