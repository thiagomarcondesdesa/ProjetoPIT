using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class ItemPedido
    {
        Pedido _pedido;
        Produto _produto;
        double _quantidade;
        double _valorunitario;

        public ItemPedido(Pedido pedido, Produto produto, double quantidade, double valorunitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            Valorunitario = valorunitario;
        }

        public Pedido Pedido { get => _pedido; set => _pedido = value; }
        public Produto Produto { get => _produto; set => _produto = value; }
        public double Quantidade { get => _quantidade; set => _quantidade = value; }
        public double Valorunitario { get => _valorunitario; set => _valorunitario = value; }
    }
}
