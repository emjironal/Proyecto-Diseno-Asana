using Proyecto_Diseno_Asana.control;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Diseno_Asana.vista
{
    public partial class GUIConsultas : Form
    {
        IController control;
        public GUIConsultas()
        {
            control = Controlador.getInstance();
            InitializeComponent();
            btnConsultar.ForeColor = Color.White;
            btnReporte.ForeColor = Color.White;
           /* try
            {*/
                loadProyectos();
                loadActividades();
                loadMiembros();/*
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }

        private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateFrom.Visible = false;
            dateFrom.Visible = false;
            Criterio.Visible = false;
            label2.Visible = false;
            cBCriterio.Visible = false;
            lblProyecto.Visible = false;
            cBProyecto.Visible = false;
            switch (cBTipo.SelectedIndex)
            {
                case 0:
                    //Consulta por miembro
                    Criterio.Text = "Miembro";
                    label2.Text = ":";
                    Criterio.Visible = true;
                    label2.Visible = true;
                    cBCriterio.Visible = true;
                    lblProyecto.Visible = true;
                    cBProyecto.Visible = true;
                    break;
                case 1:
                    //Consulta por actividad
                    Criterio.Text = "Actividad";
                    label2.Text = ":";
                    Criterio.Visible = true;
                    label2.Visible = true;
                    cBCriterio.Visible = true;
                    break;
                case 2:
                    //Consulta por fecha
                    dateFrom.Visible = true;
                    dateTo.Visible = true;
                    break;
            }
        }

        private void CBProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void loadMiembros()
        {
            cBCriterio.Items.Clear();
            Controlador ctrl = Controlador.getInstance();
            List<Usuario> usrs = ctrl.consultarUsuarios();
            foreach (Usuario u in usrs)
            {
                cBCriterio.Items.Add(u);
            }
            cBCriterio.DisplayMember = "nombre";
            cBCriterio.ValueMember = "id";

        }

        private void loadActividades()
        {
            cBCriterio.Items.Clear();
            List<Tarea> tareas = Controlador.getInstance().consultarActividades();
            foreach(Tarea t in tareas)
            {
                cBCriterio.Items.Add(t);
            }
            cBCriterio.DisplayMember = "nombre";
            cBCriterio.ValueMember = "codigo";
        }

        private void loadProyectos()
        {
            List<Proyecto> proyectos = Controlador.getInstance().consultarProyectos();
            foreach(Proyecto p in proyectos)
            {
                cBProyecto.Items.Add(p);
            }
            cBProyecto.DisplayMember = "nombre";
            cBProyecto.ValueMember = "id";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (cBTipo.SelectedIndex)
            {
                case 0:
                    //Consulta por miembro
                    String idProyecto = ((Proyecto)cBProyecto.SelectedItem).id;
                    String usuario = ((Usuario)cBCriterio.SelectedItem).id;
                    object[] criterio = { null, idProyecto, usuario };
                    control.hacerConsulta("miembro", criterio);
                    break;
                case 1:
                    String idActividad = ((Tarea)cBCriterio.SelectedItem).codigo;
                    object[] criterio2 = { null, idActividad };
                    control.hacerConsulta("actividad", criterio2);
                    break;
                case 2:
                    String fchInicial = dateFrom.Value.ToString("yyyy-MM-dd");
                    String fchFinal = dateTo.Value.ToString("yyyy-MM-dd");
                    object[] criterio3 = { null, fchInicial, fchFinal };
                    control.hacerConsulta("fecha", criterio3);
                    break;
            }
            tBResult.Text = "";
            foreach (Avance avance in control.dto.avances)
            {
                tBResult.Text += "Nota: " + avance.descripción + "\n";
                tBResult.Text += "Horas dedicadas: " + avance.HorasDedicadas.ToString() +"\n";
                tBResult.Text += "Creador: " + (avance.creador == null ? "" : avance.creador.nombre) + "\n";
                tBResult.Text += "Cantidad de evidencias: " + avance.cantidadEvidencias.ToString() + "\n";
                tBResult.Text += "\n";
            }
            btnReporte.Enabled = true;
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            control.generarReportePDF();
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string filename = "Reporte "+ cBTipo.SelectedItem.ToString() + DateTime.Now.ToString();
            control.guardarReportePDF(path, filename);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
