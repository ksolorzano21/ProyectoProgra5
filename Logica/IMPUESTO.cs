using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class IMPUESTO
    {
        int Id_Impuesto { get; }

        string Impuesto { get; }

        string CodigoImpuesto { get; }

        //Luego de Atributos se escribe los metodos

        public DataTable Listar()
        {
            DataTable Ret = new DataTable();



            return Ret;
        }
    }
}
