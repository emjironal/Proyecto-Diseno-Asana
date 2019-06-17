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
            int i = 0, j = 0, k = 0, l = 0;
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
                    foreach (Avance a in t2.avances)
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add("A: "+a.creador.nombre);
                        treeView1.Nodes[i].Nodes[j].Nodes[k].Tag = a;
                        k++;
                    }
                    foreach (Tarea t3 in t2.tareas)
                    {
                        treeView1.Nodes[i].Nodes[j].Nodes.Add(t3.nombre);
                        treeView1.Nodes[i].Nodes[j].Nodes[k].Tag = t3;
                        l = 0;
                        foreach (Avance a2 in t3.avances)
                        {
                            treeView1.Nodes[i].Nodes[j].Nodes[k].Nodes.Add("A: " + a2.creador.nombre);
                            treeView1.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Tag = a2;
                            l++;
                        }
                        k++;
                    }
                    j++;
                }
                i++;
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is Tarea)
            {
                gBEvidencias.Visible = false;
                Tarea t = (Tarea)e.Node.Tag;
                lNombreTarea.Text = t.nombre;
                lEncargado.Text = (t.encargado != null ? t.encargado.nombre : "Sin asignar");
                lFchEntrega.Text = (t.fchEntrega != null ? t.fchEntrega.ToString("dd/MM/yyyy") : "Sin asignar");
                lNotas.Text = (t.notas != null ? t.notas : "");
                btnAgregarAvance.Enabled = t.tareas.Count == 0;
            }
            else
            {
                btnAgregarAvance.Enabled = false;
                gBEvidencias.Visible = true;
                Avance a = (Avance)e.Node.Tag;
                lNombreTarea.Text = "Avance";
                lEncargado.Text = a.creador.nombre;
                lFchEntrega.Text = a.Fecha.ToString("dd/MM/yyyy");
                lNotas.Text = a.descripción;
                foreach (Evidencia evidencia in a.evidencias)
                {
                    dataGridView1.Rows.Add(a.id, a.creador, a.Fecha.ToString("dd/MM/yyyy"));
                }
            }
        

        }

        private void GBAvances_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idAvance = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void BtnAgregarAvance_Click(object sender, EventArgs e)
        {
            Controlador.getInstance().getDTO().setTarea((Tarea)treeView1.SelectedNode.Tag);
            Form avance = new GUIAvance();
            avance.ShowDialog();
        }
    }
}
