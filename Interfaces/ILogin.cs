using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface ILogin
    {
         string Logar(Usuario user);
         string Deslogar(Usuario user);
    }
}