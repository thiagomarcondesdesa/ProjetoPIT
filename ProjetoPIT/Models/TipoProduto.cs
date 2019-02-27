using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class TipoPedido
    {
        int _id;
        string descricao;
        string observacao;

        public TipoPedido(int id, string descricao, string observacao)
        {
            Id = id;
            this.Descricao = descricao;
            this.Observacao = observacao;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
