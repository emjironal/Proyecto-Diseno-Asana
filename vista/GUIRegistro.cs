using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Diseno_Asana.vista
{
    public partial class GUIRegistro : Form
    {
        public GUIRegistro()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.nombre = tBNombre.Text;
            usr.correo = tBCorreo.Text;
            usr.isAdministrador = cBisAdmin.Checked;
            Controlador controlador = Controlador.getInstance();
            controlador.getDTO().setUsuario(usr);
            if (controlador.completarUsuario())
            {
                System.Windows.Forms.MessageBox.Show("Usuario actualizado exitosamente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: no se pudo actualizar el usuario");
            }

            tBNombre.Text = "";
            tBCorreo.Text = "";
            cBisAdmin.Checked = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
