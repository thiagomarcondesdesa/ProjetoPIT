using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Cidade
    {
        int _id;
        string _nome;
        string _uf;

        public Cidade(int id, string nome, string uf)
        {
            Id = id;
            Nome = nome;
            Uf = uf;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Uf { get => _uf; set => _uf = value; }
    }
}
