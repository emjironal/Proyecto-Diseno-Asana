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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUILogin());
        }

        public GUILogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Controlador ctrl = Controlador.getInstance();
            ctrl.getDTO().getUsuario().id = tBCorreo.Text;
            if (ctrl.login())
            {
                this.Hide();
                if (ctrl.getDTO().getUsuario().isAdministrador)
                {

                    Form mainAdmin = new GUIMainAdministrador();
                    mainAdmin.ShowDialog();
                }
                else
                {
                    Form mainMiembro = new GUIMainMiembro();
                    mainMiembro.ShowDialog();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: usuario no existe");
            }
        }

        private void GUILogin_Load(object sender, EventArgs e)
        {

        }
    }
}
