using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.control;
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
            loadComboBoxID();
        }

        

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCompletar_Click_1(object sender, EventArgs e)
        {
            NewController ctrl = NewController.getInstance();
            Usuario usr = new Usuario();
            usr.correo = tBCorreo.Text;
            usr.id = ((Usuario)cBID.SelectedItem).id;
            usr.isAdministrador = cBIsAdmin.Checked;
            ctrl.getDTO().setUsuario(usr);
            if (ctrl.completarUsuario())
            {
                System.Windows.Forms.MessageBox.Show("Usuario completado correctamente");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error, no se pudo completar el usuario");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void loadComboBoxID()
        {
            NewController ctrl = NewController.getInstance();
            List<Usuario> usrs = ctrl.consultarUsuarios();
            foreach(Usuario u in usrs)
            {
                cBID.Items.Add(u);
            }
            cBID.DisplayMember = "nombre";
            cBID.ValueMember = "id";
        }
    }
}
