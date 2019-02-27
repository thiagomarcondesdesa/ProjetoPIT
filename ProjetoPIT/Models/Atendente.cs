using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Atendente : Pessoa
    {
        string _login;
        string _senha;
        string _tipo;

        public Atendente(string login, string senha, string tipo)
        {
            _login = login;
            _senha = senha;
            _tipo = tipo;
        }
    }
}
