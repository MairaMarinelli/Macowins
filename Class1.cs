using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macowins
{
    public enum ModoDePago:int
    {
        tarjeta =0,
        efectivo =1
    }
    public enum TipoPrenda:int
    {
        camisa=0,
        pantalon=1,
        saco=2
    }
    public enum EstadoPrenda : int
    {
        nuevo=0,
        promocion=1,
        liquidacion=2
    }
    public class MarcaMacowins
    {
        List<Sucursal> ListSucursales = new List<Sucursal>(); //Una lista que tiene todas las sucursales

        /* Suma las ganancias de todas las sucursales*/
        public float GananciasTotales()
        {
            float a=0;
            return a;
        }
    }
    public class Sucursal
    {
        List<Venta> ListVentas = new List<Venta>(); //tiene la informacion de las ventas de esa sucursal particular
        List<Prenda> ListsucursalPrendas = new List<Prenda>(); //tiene la cantidad de prendas que tiene la sucursal
        
        /* Suma el precio de la lista de las ventas */
        public float GananciasSucursal() 
        {
            float a=0;
            return a;
        }
    }
    public class Venta
    {
        List<Prenda> ListventaPrendas = new List<Prenda>(); //datos de las prendas que se vendieron 
        public string Fecha { get; set; }
        public int ModoDePago { get; set; } //enum

        /*Lo que hace CalcularPrecio es agarrar la informacion de la lista de prendas, multiplica la cantidad por el
         precio dependiendo del estado de la prenda y le suma en caso de ser tarjeta, el recargo de las cuotas*/ 
        public float CalcularPrecio() 
        {
            float a=0;
            return a;
        }
    }
    public class Prenda
    {
        public float PrecioBase { get; set; }
        public int Tipo { get; set; } 
        public int Estado  { get; set; } 
        public int Cantidad { get; set; }
    }
}
