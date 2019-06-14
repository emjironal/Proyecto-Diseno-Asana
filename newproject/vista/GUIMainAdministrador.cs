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
    public partial class GUIMainAdministrador : Form
    {
       
        public GUIMainAdministrador()
        {
            InitializeComponent();
            LoadProyects();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }



        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new GUIRegistro();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
            }
            if (Controlador.getInstance().importarProyecto(path))
            {
                System.Windows.Forms.MessageBox.Show("Proyecto importado correctamente");
            }

        }

        private void GUIMainAdministrador_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadProyects()
        {
            List<Proyecto> proyectos = Controlador.getInstance().consultarProyectos();
            foreach(Proyecto p in proyectos)
            {
                dataGridView1.Rows.Add(p.id, p.nombre);
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controlador ctrl = Controlador.getInstance();

            if (e.ColumnIndex == 1)
            {
                //Actualiza proyecto
                string path = "";
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                }
                if (ctrl.actualizarProyecto(path))
                {
                    System.Windows.Forms.MessageBox.Show("Proyecto importado correctamente");
                }
            }
            else if (e.ColumnIndex == 2)
            {
                //Abre poryecto
                Proyecto p = new Proyecto();
                p.id = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                p.nombre = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                ctrl.getDTO().setProyecto(p);
                ctrl.abrirProyecto();
            }
        }
    }
}
