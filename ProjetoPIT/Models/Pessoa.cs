using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Pessoa
    {
        int _id;
        string _nome;
        string _endereco;
        int _numero;
        string _bairro;
        string _cep;
        Cidade _cidade;
        string _telefone;
        string _celular;
        string _email;

        public Pessoa(int id, string nome, string endereco, int numero, string bairro, string cep, Cidade cidade, string telefone, string celular, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public Cidade Cidade { get => _cidade; set => _cidade = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
