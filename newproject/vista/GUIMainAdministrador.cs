using Proyecto_Diseno_Asana.modelo;
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
    public partial class GUIMainAdministrador : Form, FiltroVista
    {

        string path = "";
        public GUIMainAdministrador()
        {
            InitializeComponent();
            LoadProyects();
        }

        public void filtrar()
        {
            btnImportar.Visible = false;
            btnCompletar.Visible = false;
            btnConsultas.Visible = false;
            dataGridView1.Columns[2].Visible = false;
            label1.Text = "Menú miembro";
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
            
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                using(WaitForm frm = new WaitForm(Importar))
                {
                    frm.ShowDialog(this);
                }
                LoadProyects();
                System.Windows.Forms.MessageBox.Show("Proyecto importado correctamente");

            }

        }

        void Importar()
        {
            Controlador.getInstance().importarProyecto(path);
        }

        void Actializar()
        {
            Controlador.getInstance().actualizarProyecto(path);
        }
        
        void AbrirPoyecto()
        {
            Controlador.getInstance().abrirProyecto();
        }
       

        private void GUIMainAdministrador_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadProyects()
        {
            dataGridView1.Rows.Clear();
            List<Proyecto> proyectos = Controlador.getInstance().consultarProyectos();
            foreach(Proyecto p in proyectos)
            {
                dataGridView1.Rows.Add(p.id, p.nombre);
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controlador ctrl = Controlador.getInstance();

            if (e.ColumnIndex == 2)
            {
                //Actualiza proyecto
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    using (WaitForm frm = new WaitForm(Actializar))
                    {
                        frm.ShowDialog(this);
                    }
                    System.Windows.Forms.MessageBox.Show("Proyecto actualizado correctamente");
                }
            }
            else if (e.ColumnIndex == 3)
            {
                //Abre poryecto
                Proyecto p = new Proyecto();
                p.id = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                p.nombre = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                ctrl.getDTO().setProyecto(p);
                using (WaitForm frm = new WaitForm(AbrirPoyecto))
                {
                    frm.ShowDialog(this);
                }
                this.Hide();
                Form guiProyecto = new GUIProyecto();
                guiProyecto.ShowDialog();
                this.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form guiconsulta = new GUIConsultas();
            guiconsulta.ShowDialog();
            this.Show();
        }
    }
}
