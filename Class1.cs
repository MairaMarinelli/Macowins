using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macowins
{
    public class MarcaMacowins
    {
        List<Sucursal> ListSucursales = new List<Sucursal>(); //Una lista que tiene todas las sucursales

        /* Suma las ganancias de todas las sucursales*/
        public float GananciasTotales()
        {
            float a;
            return a;
        }
    }
    public class Sucursal
    {
        List<Ventas> ListVentas = new List<Ventas>(); //tiene la informacion de las ventas de esa sucursal particular
        List<Prendas> ListsucursalPrendas = new List<Prendas>(); //tiene la cantidad de prendas que tiene la sucursal
        
        /* Suma el precio de la lista de las ventas */
        public float GananciasSucursal() 
        {
            float a;
            return a;
        }
    }
    public class Ventas
    {
        List<Prendas> ListventaPrendas = new List<Prendas>(); //datos de las prendas que se vendieron 
        public string Fecha { get; set; }
        public int ModoDePago { get; set; } //enum

        /*Lo que hace CalcularPrecio es agarrar la informacion de la lista de prendas, multiplica la cantidad por el
         precio dependiendo del estado de la prenda y le suma en caso de ser tarjeta, el recargo de las cuotas*/ 
        public float CalcularPrecio() 
        {
            float a;
            return a;
        }
    }
    public class Prendas
    {
        public float PrecioBase { get; set; }
        public int Tipo { get; set; } //enum
        public int Estado  { get; set; } //enum
        public int Cantidad { get; set; }
    }
}
