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
using System.Data;

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
                    GestorBaseDatos bd = new PostgresBaseDatos("35.239.31.249", "postgres", "5432", "E@05face", "postgres");
                    Object[] s = bd.consultar("SELECT * FROM Proyecto;", 3);
                    Console.WriteLine(s[0]);
                    break;
                case "4":
                    abrirProyecto();
                    break;
                default:
                    print("Opción no válida");
                    break;
            }
            return false;
        }

        static private void abrirProyecto()
        {
            print("Id del proyecto:");
            string idProyecto = input();
            Proyecto proyecto = control.dto.getProyecto();
            if(idProyecto != proyecto.id)
            {
                print("No exite el proyecto");
            }
            else
            {
                print("Id: " + proyecto.id);
                print("Nombre: " + proyecto.nombre);
                print("Administrador: " + proyecto.administradorProyecto.nombre);
                print("Miembros: ");
                foreach (Usuario miembro in proyecto.miembros)
                {
                    print("\tNombre: " + miembro.nombre);
                }
                print("Secciones:");
                foreach(Tarea seccion in proyecto.secciones)
                {
                    print("\tSeccion: " + seccion.nombre);
                    print("\tTareas: ");
                    foreach (Tarea tarea in seccion.tareas)
                    {
                        print("\t\tTarea: " + tarea.nombre);
                        print("\t\tDescripción: " + tarea.notas);
                        print("\t\tEncargado: " + (tarea.encargado == null ? "No hay" : tarea.encargado.nombre));
                        foreach(Usuario seguidor in tarea.seguidores)
                        {
                            print("\t\t\tSeguidor: " + seguidor.nombre);
                        }
                        print("\t\tSubtareas:");
                        foreach (Tarea subtarea in tarea.tareas)
                        {
                            print("\t\t\tSubtarea: " + subtarea.nombre);
                        }
                        print("\t\tAvances:");
                        foreach (Avance avance in tarea.avances)
                        {
                            print("\t\t\tNota: " + avance.descripción);
                            print("\t\t\tHoras dedicadas: " + avance.HorasDedicadas.ToString());
                        }
                    }
                }
            }
        }

        static private void agregarAvance()
        {
            print("Descripción:");
            string descripcion = input();
            print("Horas dedicadas:");
            int horas;
            if(int.TryParse(input(), out horas))
            {
                Avance avance = control.dto.getAvance();
                avance.creador = control.dto.getUsuario();
                avance.descripción = descripcion;
                avance.HorasDedicadas = horas;
                avance.Fecha = DateTime.Now;
                avance.id = control.dto.getTarea().avances.Count;
                control.agregarAvance();
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
            print("4. Abrir proyecto");
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
