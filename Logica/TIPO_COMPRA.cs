using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class TIPO_COMPRA
    {
        //Primero se escriben los atributos

        int ID_TipoCompra { get; }

        string TipoCompra { get; }

        //Luego de Atributos se escribe los metodos

        public DataTable Listar()
        {
            DataTable Ret = new DataTable();



            return Ret;
        }
    }
}
