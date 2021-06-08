using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Login : ILogin
    {
        public bool logado;

        public Login(){
            int IDuser = 1;
            Console.WriteLine("Entramos no sistema, vamos te cadastrar");

            Usuario u = new Usuario(IDuser);

            Console.WriteLine(u.Cadastrar(u));

            while(logado == false){
                Console.WriteLine(Logar(u));
            }

            Console.WriteLine($@"Estamos no sistema, o que você deseja fazer?
            ");

        }

        public string Deslogar(Usuario user)
        {
            logado = false;
            return "Saindo do sistema"; 
        }

        public string Logar(Usuario user)
        {
            Console.WriteLine("\n Digite seu nome");
            string nomeDigitado = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            string senhaDigitada = Console.ReadLine();
            
            if (user.Nome == nomeDigitado && user.Senha == senhaDigitada)
            {
                logado = true;
                return "Você pode entrar no sistema";
            } else
            {
                logado = false;
                return "Você digitou algo errado, os dados não condizem com os do sistema";
            }
            
        }
    }
}