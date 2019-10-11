using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class COMPRA_DETALLE
    {
        public COMPRA_DETALLE()
        {
            //Constructor  basico de la clase
            //se debe instanciar los atributos compuestos
            MiProducto = new PRODUCTO();

        }


        decimal PrecioUnitario { get; set; }

        decimal Cantidad { get; set; }

        decimal Impuesto { get; set; }

        decimal PorcentajeImpuesto { get; set; } = 0;

        decimal Descuento { get; set; } = 0;

        decimal TotalLinea { get; set; } = 0;

        //atributoscompuesto
        // Se establece el atriibuto compuesto de tipo usuario
        PRODUCTO MiProducto { get; set; }


        //Metodos de la Clase

        public PRODUCTO Agregar()
        {
            PRODUCTO R = new PRODUCTO();

            return R;
        }


    }
}
