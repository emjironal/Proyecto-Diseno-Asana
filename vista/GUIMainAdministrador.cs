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
    public partial class GUIMainAdministrador : Form
    {
        public GUIMainAdministrador()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Abre menu de administrador
            this.Hide();
            Form gUIRegistro = new GUIRegistro();
            gUIRegistro.Show();
        }

        private void BtnImportNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if (Controlador.getInstance().importarProyecto(fileName))
                {
                    System.Windows.Forms.MessageBox.Show("Proyecto importado exitosamente");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error: No se pudo importar el proyecto");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error: no se pudo seleccionar el archivo ");
            }
        }
    }
}
