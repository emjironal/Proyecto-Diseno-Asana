using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.modelo;

namespace Proyecto_Diseno_Asana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Fabrica fabrica = new FabricaImportacionProyecto();
            string json = "";
            string path = @"D:\Documents\Diseño_de_software\Proyecto 1\pruebaProyecto.json";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    json += s;
                }
            }
            Proyecto proyecto = (Proyecto)fabrica.fabricaProducto(json);
            Console.WriteLine(proyecto.secciones.First().tareas.First().codigo);
        }
    }
}
