using System;
using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int IDuser = 1;

            Usuario u = new Usuario(IDuser);

            u.Cadastrar(u);

            u.Mostrar();
        }
    }
}
