using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIT.Models
{
    public class Pedido
    {
        int _id;
        Cliente _cliente;
        DateTime _data;
        string status;
        double _descontoTotal;
        double _valorBruto;
        double _valorLiquido;  
        List<ItemPedido> _ItensPedido;

        public Pedido(int id, Cliente cliente, DateTime data, string status, double descontoTotal, double valorBruto, double valorLiquido, List<ItemPedido> ItensPedido)
        {
            Id = id;
            Cliente = cliente;
            Data = data;
            this.Status = status;
            DescontoTotal = descontoTotal;
            ValorBruto = valorBruto;
            ValorLiquido = valorLiquido;
            this.ItensPedido = ItensPedido;
        }

        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Status { get => status; set => status = value; }
        public double DescontoTotal { get => _descontoTotal; set => _descontoTotal = value; }
        public double ValorBruto { get => _valorBruto; set => _valorBruto = value; }
        public double ValorLiquido { get => _valorLiquido; set => _valorLiquido = value; }
        public List<ItemPedido> ItensPedido { get => _ItensPedido; set => _ItensPedido = value; }
    }
}
