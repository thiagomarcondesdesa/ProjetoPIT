using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class ItemPedido
    {
        Produto _produto;
        double _quantidade;
        double _valorUnitario;
        double _valorDesconto;

        public ItemPedido(Produto produto, double quantidade, double valorUnitario, double valorDesconto)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorDesconto = valorDesconto;
        }

        public Produto Produto { get => _produto; set => _produto = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public double ValorUnitario { get => _valorUnitario; set => _valorUnitario = value; }
        public double ValorDesconto { get => _valorDesconto; set => _valorDesconto = value; }
    }
}
