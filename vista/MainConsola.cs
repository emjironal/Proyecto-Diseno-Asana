using Proyecto_Diseno_Asana.control.fabrica;
using Proyecto_Diseno_Asana.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Diseno_Asana.control.gestor;
using Proyecto_Diseno_Asana.control.gestor.bd;

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
                case "2":
                    agregarAvance();
                    break;
                case "3":
                    GestorBaseDatos gestor = new PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "postgres");
                    gestor.conectar();
                    Object[] result = gestor.consultar("Select * from proyecto;");
                    Object t = result.First(); 
                    Console.WriteLine(t);
                    gestor.desconectar();
                    break;
                default:
                    print("Opción no válida");
                    break;
            }
            return false;
        }

        static private void agregarAvance()
        {
            print("Descripción:");
            string descripcion = input();
            print("Horas dedicadas:");
            int horas;
            if(int.TryParse(input(), out horas))
            {
                control.agregarAvance(descripcion, horas);
            }
            else
            {
                print("No es un integer");
            }
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
            print("2. Agregar avance");
            print("3. Probar conexion");
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
