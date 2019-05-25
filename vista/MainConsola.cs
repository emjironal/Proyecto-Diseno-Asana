using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Diseno_Asana.vista
{
    class MainConsola
    {
        static Controlador control = Controlador.getInstance();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                menu();
                string input = Console.ReadLine();
                print();
                exit = executeMenu(input);
                print();
            }
        }

        static private bool executeMenu(string entry)
        {
            switch (entry.ToUpper())
            {
                case "S":
                    return true;
                case "1":
                    importarProyecto();
                    break;
                default:
                    print("Opción no válida");
                    break;
            }
            return false;
        }

        static private void importarProyecto()
        {
            print("Ingrese el path del json del proyecto de asana");
            if (control.importarProyecto(input()))
            {
                print("El proyecto se importó correctamente");
            }
        }

        static private void menu()
        {
            print("Bienvenido a AsanaUpgrade");
            print();
            print("Seleccione una opción del menú:");
            print("1. Importar proyecto");
            print("S. Salir");
            print("Ingrese su elección: ");
        }

        static private void print(string str)
        {
            Console.WriteLine(str);
        }

        static private void print()
        {
            Console.WriteLine();
        }

        static private string input()
        {
            return Console.ReadLine();
        }
    }
}
