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
    public partial class GUIMainMiembro : Form
    {
        public GUIMainMiembro()
        {
            InitializeComponent();
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
                ctrl.abrirProyecto();
            }
        }
    }
}
