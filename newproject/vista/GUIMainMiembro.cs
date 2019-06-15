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
    public partial class GUIMainMiembro : Form
    {
        public GUIMainMiembro()
        {
            InitializeComponent();
            LoadProyectos();
        }

        void AbrirPoyecto()
        {
            Controlador.getInstance().abrirProyecto();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controlador ctrl = Controlador.getInstance();
            if(e.ColumnIndex == 2)
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

        private void LoadProyectos()
        {
            dataGridView1.Rows.Clear();
            List<Proyecto> proyectos = Controlador.getInstance().consultarProyectos();
            foreach (Proyecto p in proyectos)
            {
                dataGridView1.Rows.Add(p.id, p.nombre);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
