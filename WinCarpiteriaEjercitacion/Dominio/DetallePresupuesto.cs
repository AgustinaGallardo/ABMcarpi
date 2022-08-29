using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCarpiteriaEjercitacion
{
    internal class DetallePresupuesto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public DetallePresupuesto(Producto p,int cant)
        {
            Producto = p;
            Cantidad = cant;
        }
        public double CalcularSubtotal()
        {
            //double subtotal = 0;
            //subtotal = Producto.Precio * Cantidad;
            //return subtotal;
            return Producto.Precio * Cantidad;

        }
    }
}
