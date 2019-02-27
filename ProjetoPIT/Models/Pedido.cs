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
        double _valorTotal;

        public Pedido(int id, Cliente cliente, DateTime data, string status, double valorTotal)
        {
            Id = id;
            Cliente = cliente;
            Data = data;
            this.Status = status;
            ValorTotal = valorTotal;
        }

        public int Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Status { get => status; set => status = value; }
        public double ValorTotal { get => _valorTotal; set => _valorTotal = value; }
    }
}
