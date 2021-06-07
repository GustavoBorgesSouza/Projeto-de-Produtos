using System.Collections.Generic;
using AulaPOO_ProjetoDeProdutos.Interfaces;
using System;

namespace AulaPOO_ProjetoDeProdutos.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public string Email{get; set;}
        public string Senha{get; set;}
        public DateTime DataCadastro{get; set;}

        List<Usuario> users = new List<Usuario>();
        public string Cadastrar(Usuario userCadastrar)
        {
            users.Add(userCadastrar);
            return "Usuário cadastrado"; 
        }

        public string Deletar(Usuario userDeletar)
        {
            users.Remove(userDeletar);
            return "Usuário deletado";
        }
    }
}