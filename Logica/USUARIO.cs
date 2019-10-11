using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class USUARIO
    {

        public USUARIO()
        {
            //Constructor  basico de la clase
            //se debe instanciar los atributos compuestos
            TipoUsuario = new USUARIO_TIPO();
        }


        int Id_Usuario { get; }

        string Nombre { get; set; }

        string Cedula { get; set; }

        string NombreUsuario { get; set; }

        string Contrasenna { get; set; }

        string Email { get; set; }

        bool Eliminado { get; set; }

        // Se establece el atriibuto compuesto de tipo usuario
        USUARIO_TIPO TipoUsuario { get; set; }
    


        //Metodos de la Clase

        public bool Agregar()
        {
            bool R = false;

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

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorUserName()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool Activos = true)
        {
            DataTable R = new DataTable();

            //1.3.1 y 1.3.2

            CLS_CONEXION MiCnn = new CLS_CONEXION();

            // Se deben agregar los parametros requeridos por el procedimiento Almacenado
            // en este caso @Activos

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Activo", Activos));

            //1.3.3

            R = MiCnn.HacerSelect("SP_Usuario_Listar");


            return R;
        }

        public DataTable ListarConFiltro (string Filtro)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
