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
    public partial class GUIProyecto : Form
    {
        public GUIProyecto()
        {
            InitializeComponent();
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            int i = 0, j = 0, k = 0;
            Proyecto p = Controlador.getInstance().getDTO().getProyecto();

            lNombreProyecto.Text = p.nombre;

            foreach(Tarea t in p.secciones)
            {
                treeView1.Nodes.Add(t.nombre);
                treeView1.Nodes[i].Tag = t;
                j = 0;
                foreach(Tarea t2 in t.tareas)
                {
                    treeView1.Nodes[i].Nodes.Add(t2.nombre);
                    treeView1.Nodes[i].Nodes[j].Tag = t2;
                    k = 0;
                    foreach (Tarea t3 in t2.tareas)
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add(t3.nombre);
                        treeView1.Nodes[i].Nodes[j].Nodes[k].Tag = t3;
                        k++;
                    }
                    j++;
                }
                i++;
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Tarea t = (Tarea)e.Node.Tag;
            lNombreTarea.Text = t.nombre;
            lEncargado.Text = t.encargado.nombre;
            lFchEntrega.Text = t.fchEntrega.ToString("dd/MM/yyyy");
            lNotas.Text = t.notas;
            foreach(Avance a in t.avances)
            {
                dataGridView1.Rows.Add(a.id, a.creador, a.Fecha.ToString("dd/MM/yyyy"));
            }
            btnAgregarAvance.Enabled = t.tareas.Count == 0;

        }

        private void GBAvances_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idAvance = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}
