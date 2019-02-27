using System;

namespace ProjetoPIT
{
    public class Pessoa
    {
        int _id;
        string _nome;
        string _endereco;
        int _numero;
        string _bairro;
        string _cep;
        string _telefone;
        string _celular;
        string _email;

      

        public void Pessoa(int id, string nome, string endereco, int numero, string bairro, string cep, string telefone, string celular, string email)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.bairro = bairro;
            this.cep = cep;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
