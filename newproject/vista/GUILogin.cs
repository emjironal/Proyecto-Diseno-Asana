using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.control;
using Proyecto_Diseno_Asana.newproject.vista;
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
        [STAThread]
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

        private void TBCorreo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                attempt_log_in();
            }
        }


        private void attempt_log_in()
        {
            NewController ctrl = NewController.getInstance();
            ctrl.getDTO().getUsuario().id = tBCorreo.Text;
            if (ctrl.login())
            {
                this.Hide();
                ProxyVistaMain proxy = new ProxyVistaMain();
                Form main = proxy.vista;
                main.ShowDialog();
                tBCorreo.Text = "";
                this.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: usuario no existe");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            attempt_log_in();
        }

        

        private void GUILogin_Load(object sender, EventArgs e)
        {

        }
    }
}
