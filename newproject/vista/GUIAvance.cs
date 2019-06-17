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
        Controlador controlador;
        public GUIAvance()
        {
            InitializeComponent();
            limpiarTabla();
            controlador = Controlador.getInstance();
        }

        private void Btn_registrar_avance_Click(object sender, EventArgs e)
        {
            controlador.agregarAvance();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            controlador.dto.setAvance(new modelo.Avance());
            this.Visible = false;
            this.ParentForm.Visible = true;
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
