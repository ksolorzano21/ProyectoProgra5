using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class USUARIO_TIPO
    {
        //Primero se escriben los atributos

        int Id_Usuario_Tipo { get;} // solo devuelve el dato no lo vamos a modificar

        String Tipo { get;}

        //Luego de Atributos se escribe los metodos

        DataTable Listar()
        {
            DataTable Ret = new DataTable();



            return Ret;

        }

    }
}
