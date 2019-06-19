using Proyecto_Diseno_Asana.control;
using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.control;
using Proyecto_Diseno_Asana.newproject.vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Diseno_Asana.vista
{
    public partial class GUIConsultas : Form
    {
        NewController control;
        string tipo, path, filename;
        object[] criterio;
        public GUIConsultas()
        {
            control = NewController.getInstance();
            InitializeComponent();
            btnConsultar.ForeColor = Color.White;
            btnReporte.ForeColor = Color.White;
            loadProyectos();
        }

        private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateFrom.Visible = false;
            dateTo.Visible = false;
            cBCriterio.Visible = false;
            cBProyecto.Visible = false;
            switch (cBTipo.SelectedIndex)
            {
                case 0:
                    //Consulta por miembro
                    lblProyecto.Text = "Proyecto";
                    Criterio.Text = "Miembro:";
                    loadMiembros();
                    cBCriterio.Visible = true;
                    cBProyecto.Visible = true;
                    break;
                case 1:
                    //Consulta por actividad
                    lblProyecto.Text = "Proyecto";
                    Criterio.Text = "Actividad:";
                    cBProyecto.Visible = true;
                    cBCriterio.Visible = true;
                    break;
                case 2:
                    //Consulta por fecha
                    lblProyecto.Text = "Desde:";
                    Criterio.Text = "Hasta:";
                    dateFrom.Visible = true;
                    dateTo.Visible = true;
                    break;
            }
            Criterio.Visible = true;
            lblProyecto.Visible = true;
        }

        private void CBProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            control.getDTO().getProyecto().id = ((Proyecto)cBProyecto.SelectedItem).id;
            if (cBTipo.SelectedIndex == 0)
            {
                loadMiembros();
            }
            else
            {
                loadActividades();
            }
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            switch (cBTipo.SelectedIndex)
            {
                case 0:
                    //Consulta por miembro
                    String idProyecto = ((Proyecto)cBProyecto.SelectedItem).id;
                    String usuario = ((Usuario)cBCriterio.SelectedItem).id;
                    object[] criterio = { null, idProyecto, usuario };
                    this.criterio = criterio;
                    tipo = "miembro";
                    break;
                case 1:
                    String idActividad = ((Tarea)cBCriterio.SelectedItem).codigo;
                    object[] criterio2 = { null, idActividad };
                    this.criterio = criterio2;
                    tipo = "actividad";
                    break;
                case 2:
                    String fchInicial = dateFrom.Value.ToString("yyyy-MM-dd");
                    String fchFinal = dateTo.Value.ToString("yyyy-MM-dd");
                    object[] criterio3 = { null, fchInicial, fchFinal };
                    this.criterio = criterio3;
                    tipo = "fecha";
                    break;
            }
            using (WaitForm frm = new WaitForm(Consultar))
            {
                frm.ShowDialog(this);
            }
            tBResult.Text = "";
            foreach (Avance avance in control.dto.avances)
            {
                tBResult.AppendText("Nota: " + avance.descripción + Environment.NewLine);
                tBResult.AppendText("Horas dedicadas: " + avance.HorasDedicadas.ToString() + Environment.NewLine);
                tBResult.AppendText("Creador: " + (avance.creador == null ? "" : avance.creador.nombre) + Environment.NewLine);
                tBResult.AppendText("Cantidad de evidencias: " + avance.cantidadEvidencias.ToString() + Environment.NewLine);
                tBResult.AppendText(Environment.NewLine);

            }
            btnReporte.Enabled = true;
        }

        void Consultar()
        {
            control.hacerConsulta(tipo, criterio);
        }

        void GenerarReporte()
        {
            control.generarReportePDF();
            control.guardarReportePDF(path, filename);
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ValidateNames = false;
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;
            dialog.FileName = "Folder Selection";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetDirectoryName(dialog.FileName);               
                filename = "Reporte " + cBTipo.SelectedItem.ToString()+" " + DateTime.Now.ToString("dd-MM-yyyy H.mm");
                using (WaitForm frm = new WaitForm(GenerarReporte))
                {
                    frm.ShowDialog(this);
                }
                System.Windows.Forms.MessageBox.Show("Reporte generado correctamente");
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
