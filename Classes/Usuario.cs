using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo{get; set;}
        public string Nome{get;}
        public string Email{get;}
        public string Senha{get;}
        public DateTime DataCadastro{get; set;}

        List<Usuario> users = new List<Usuario>();

        public Usuario(int IDuser){
            Codigo = IDuser;
            Console.WriteLine("Qual é nome do usuario?");
            Nome = Console.ReadLine();
            Console.WriteLine("Qual é o email do usuario?");
            Email = Console.ReadLine();
            Console.WriteLine("Qual é a senha do usuario?");
            Senha = Console.ReadLine();

            DataCadastro = DateTime.Now;
            IDuser++;
        }
        public string Cadastrar(Usuario userCadastrar)
        {
            users.Add(userCadastrar);
            return "Usuário cadastrado"; 
        }

        public void Mostrar(){
            foreach (Usuario item in users)
            {
                Console.WriteLine($"{item.Nome} e codigo {item.Codigo}");
            }
        }

        public string Deletar(Usuario userDeletar)
        {
            users.Remove(userDeletar);
            return "Usuário deletado";
        }
    }
}