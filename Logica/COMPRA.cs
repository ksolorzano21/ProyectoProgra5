using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class COMPRA
    {
        public COMPRA()
        {
            //Constructor  basico de la clase
            //se debe instanciar los atributos compuestos
            MiUsuario = new USUARIO();

            MiProveedor = new PROVEEDOR();

            MiTipoCompra = new TIPO_COMPRA();

            ListaDetalles = new List<COMPRA_DETALLE>();

        }

        int Id_Compra { get; }

        DateTime Fecha { get; set; }

        //atributoscompuesto
        // Se establece el atriibuto compuesto de tipo usuario
        USUARIO MiUsuario { get; set; }

        PROVEEDOR MiProveedor { get; set; }

        TIPO_COMPRA MiTipoCompra { get; set; }

        List<COMPRA_DETALLE> ListaDetalles { get; set; }

        //Metodos de la Clase

        public bool Agregar()
        {
            bool R = false;

            return R;
        }


        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(DateTime FechaInicio, DateTime FechaFinal)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable Listar(DateTime FechaInicio, DateTime FechaFinal, int IDProveedor)
        {
            DataTable R = new DataTable();

            return R;
        }

        //Los parametros con valores por defecto se ponen al final
        public DataTable Listar(DateTime FechaInicio , DateTime FechaFinal, int TipoFactura, int IDProveedor = 0)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
