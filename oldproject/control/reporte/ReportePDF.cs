using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proyecto_Diseno_Asana.control.reporte
{
    class ReportePDF : Reporte
    {
        public Boolean generarReporte()
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("reporte.pdf", FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Reporte generado a las: " + DateTime.Now.ToString("hh:mm:ss") + " del " + DateTime.Now.ToString("dd/MM/yyyy")));
            foreach (modelo.Avance avance in Controlador.getInstance().dto.avances)
            {
                document.Add(new Paragraph(avance.ToString()));
            }
            document.Close();
            return true;
        }

        public Boolean guardarReporte(string pathWithNameNoExtension)
        {
            try
            {
                File.WriteAllBytes(pathWithNameNoExtension + ".pdf", File.ReadAllBytes("reporte.pdf"));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
