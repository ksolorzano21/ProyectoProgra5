using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class PROVEEDOR
    {
        int Id_Proveedor { get; }

        string Cedula { get; set; }

        string Nombre { get; set; }

        string Telefono { get; set; }

        string Direccion { get; set; }

        string Email { get; set; }

        bool Eliminado { get; set; }

        //Metodos de la Clase

        public PROVEEDOR Agregar()
        {
            PROVEEDOR R = new PROVEEDOR();

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

        public PROVEEDOR ConsultarPorId()
        {
            PROVEEDOR R = new PROVEEDOR();

            return R;
        }

        public PROVEEDOR ConsultarPorCedula()
        {
            PROVEEDOR R = new PROVEEDOR();

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
