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
        Form guiPadre;
        public GUIRegistro(Form padre)
        {
            guiPadre = padre;
            InitializeComponent();
        }

        

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            Controlador ctrl = Controlador.getInstance();
            Usuario usr = new Usuario();
            usr.correo = tBCorreo.Text;
            usr.nombre = tBNombre.Text;
            usr.isAdministrador = cBisAdmin.Checked;
            ctrl.getDTO().setUsuario(usr);
            if (ctrl.completarUsuario())
            {
                System.Windows.Forms.MessageBox.Show("Usuario completado correctamente");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error, no se pudo completar el usuario");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            guiPadre.ShowDialog();
        }
    }
}
