using Proyecto_Diseno_Asana.modelo;
using Proyecto_Diseno_Asana.newproject.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Diseno_Asana.vista
{
    public partial class GUIAvance : Form
    {
        NewController controlador;
        public GUIAvance()
        {
            InitializeComponent();
            limpiarTabla();
            controlador = NewController.getInstance();
            controlador.dto.setAvance(new Avance());

        }

        private void Btn_registrar_avance_Click(object sender, EventArgs e)
        {

            Avance avance = controlador.dto.getAvance();
            avance.creador = controlador.dto.getUsuario();
            avance.descripción = txt_descripcion.Text;
            avance.HorasDedicadas = (int)spn_horas_dedicadas.Value;
            avance.Fecha = DateTime.Now;
            avance.id = "" + controlador.dto.getTarea().codigo + controlador.dto.getTarea().avances.Count;
            controlador.agregarAvance();

            System.Windows.Forms.MessageBox.Show("Avance agregado correctamente");
            this.DialogResult = DialogResult.OK;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            controlador.dto.setAvance(new modelo.Avance());
            this.DialogResult = DialogResult.OK;
        }

        private void Btn_seleccionar_archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                modelo.Evidencia evidencia = new modelo.Evidencia();
                evidencia.documento = File.ReadAllBytes(fileDialog.FileName);
                evidencia.tipo = Path.GetExtension(fileDialog.FileName);
                controlador.dto.getAvance().evidencias.Add(evidencia);
                controlador.dto.getAvance().cantidadEvidencias++;
                addRow(Path.GetFileNameWithoutExtension(fileDialog.FileName), Path.GetExtension(fileDialog.FileName));
            }
        }

        private void addRow(string name, string extension)
        {
            table_archivos_seleccionados.Rows.Add(new object[] { name, extension});
        }

        private void limpiarTabla()
        {
            table_archivos_seleccionados.Rows.Clear();
        }

    }
}
