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
    public partial class GUILogin : Form
    {
        public GUILogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.correo = this.tBCorreo.Text;
            Controlador controlador = Controlador.getInstance();
            controlador.getDTO().setUsuario(usr);
            if (controlador.login())
            {
                if (controlador.getDTO().getUsuario().isAdministrador)
                {
                    //Abre menu de administrador
                    this.Hide();
                    Form gUIMainAdministrador = new GUIMainAdministrador();
                    gUIMainAdministrador.ShowDialog();

                }
                else
                {
                    //Abre menu de usuario normal

                }
            }
            else
            {
                tBCorreo.Text = "";
                System.Windows.Forms.MessageBox.Show("Error: Usuario no existe");
            }
           
        }
    }
}
