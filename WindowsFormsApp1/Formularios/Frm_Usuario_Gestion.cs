using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra5Compras.Formularios
{
    public partial class Frm_Usuario_Gestion : Form
    {
        public Frm_Usuario_Gestion()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Usuario_Gestion_Load(object sender, EventArgs e)
        {
            this.MdiParent = Globales.ClsGlobales.MiFormularioPrincipal;

            LlenarListarUsuarios(true);

        }

        private void LlenarListarUsuarios(bool VerActivos)
        {
            //Se enumera los pasos de la secuencia solo con fines didacticos
            //1.1 Crear nueva Instancia y 1.2

            Logica.USUARIO MiUsuario = new Logica.USUARIO();

            //1.3

            DataTable Retorno;

            Retorno = MiUsuario.Listar(VerActivos);

            //1.5

            Dgv_Listado.DataSource = Retorno;

        }

        private void Dgv_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
