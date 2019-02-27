using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Produto
    {
        int _id;
        string _descricao;
        double _preco;
        string _observacao;
        int _estoque;
        TipoPedido _tipoProduto;

        public Produto(int id, string descricao, double preco, string observacao, int estoque, TipoPedido tipoProduto)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
            Observacao = observacao;
            Estoque = estoque;
            TipoProduto = tipoProduto;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }
        public int Estoque { get => _estoque; set => _estoque = value; }
        public TipoPedido TipoProduto { get => _tipoProduto; set => _tipoProduto = value; }
    }
}
