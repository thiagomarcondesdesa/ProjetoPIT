using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Cliente
    {
        Pessoa _pessoa;
        string _cpf;
        string _rg;
        string _dataNascimento;

        public Cliente(Pessoa pessoa, string cpf, string rg, string dataNascimento)
        {
            Pessoa = pessoa;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public Pessoa Pessoa { get => _pessoa; set => _pessoa = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
    }
    
}
