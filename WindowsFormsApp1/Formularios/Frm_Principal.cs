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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Mnu_Usuarios_Click(object sender, EventArgs e)
        {
            Form FormularioUsuariosGestion = new Formularios.Frm_Usuario_Gestion();
            FormularioUsuariosGestion.Show();
        }
    }
}
