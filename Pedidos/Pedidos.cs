using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string NombrePedido { get; set; }
        public string Direccion { get; set; }
        public DateTime    FechaCreacion{ get; set; }
      

        public Pedidos(int id, string nombrepedido, string direccion)
        {
            Id = id;
            NombrePedido = nombrepedido;
            Direccion = direccion;
            FechaCreacion= DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id:{Id},NombrePedido:{NombrePedido}, Direccion:{Direccion},Fecha:{FechaCreacion}";
        }
    }
}
