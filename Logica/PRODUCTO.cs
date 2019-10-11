using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class PRODUCTO
    {
        public PRODUCTO()
        {
            //Constructor  basico de la clase
            //se debe instanciar los atributos compuestos
            MiTipoIva = new TIPO_IVA();

            MiImpuesto = new IMPUESTO();
        }

        int Id_Producto { get; }

        string CodigoBarra { get; set; }

        string Cedula { get; set; }

        string Nombre { get; set; }

        decimal Cantidad { get; set; }

        decimal PrecioUnitario { get; set; }

        string Descripcion { get; set; }

        bool Eliminado { get; set; }

        //atributoscompuesto
        // Se establece el atriibuto compuesto de tipo usuario
        IMPUESTO MiImpuesto { get; set; }

        TIPO_IVA MiTipoIva { get; set; }


        //Metodos de la Clase

        public PRODUCTO Agregar()
        {
            PRODUCTO R = new PRODUCTO();

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public PRODUCTO ConsultarPorId()
        {
            PRODUCTO R = new PRODUCTO();

            return R;
        }

        public PRODUCTO ConsultarPorCB()
        {
            PRODUCTO R = new PRODUCTO();

            return R;
        }

        public DataTable Listar(bool Activos = true)
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarConFiltro(string Filtro)
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
