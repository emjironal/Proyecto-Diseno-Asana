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
using Proyecto_Diseno_Asana.control.dao;

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
                    DAOProyecto.consultarProyecto("1");
                    break;
                case "4":
                    abrirProyecto();
                    break;
                case "5":
                    abrirTarea();
                    break;
                case "6":
                    completarUsuario();
                    break;
                default:
                    print("Opción no válida");
                    break;
            }
            return false;
        }

        private static void completarUsuario()
        {
            Usuario usr = new Usuario();
            print("Inregese el ID del usuario por completar: ");
            usr.id = input();
            print("Ingrese el correo: ");
            usr.correo = input();
            print("Ingrese el nombre");
            usr.nombre = input();
            print("Ingrese si es administrador (S/N)");
            usr.isAdministrador = (input() == "S" ? true : false);
            control.getDTO().setUsuario(usr);
            if (control.completarUsuario())
            {
                print("Se completo el usuario con éxito");
            }
            else
            {
                print("Error: no se pudo comletar el usuario");
            }
        }

        static private void abrirTarea()
        {
            print("Id de la tarea");
            string idTarea = input();
            Proyecto proyecto = control.dto.getProyecto();
            foreach(Tarea seccion in proyecto.secciones)
            {
                foreach(Tarea tarea in seccion.tareas)
                {
                    if(tarea.codigo == idTarea)
                    {
                        control.dto.setTarea(tarea);
                        imprimirTarea(tarea, "");
                        return;
                    }
                }
            }
            print("No existe esa tarea en el proyecto: " + proyecto.nombre);
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
                    imprimirUsuario(miembro, "\t");
                }
                print("Secciones:");
                foreach (Tarea seccion in proyecto.secciones)
                {
                    imprimirSeccion(seccion, "\t");
                }
            }
            print();
        }

        static private void imprimirSeccion(Tarea seccion, string tabs)
        {
            print(tabs + "Seccion: " + seccion.nombre);
            print(tabs + "Tareas: ");
            foreach (Tarea tarea in seccion.tareas)
            {
                imprimirTarea(tarea, tabs + "\t");
            }
            print();
        }

        static private void imprimirTarea(Tarea tarea, string tabs)
        {
            print(tabs + "Tarea: " + tarea.nombre);
            print(tabs + "Descripción: " + tarea.notas);
            print(tabs + "Encargado: " + (tarea.encargado == null ? "No hay" : tarea.encargado.nombre));
            print(tabs + "Seguidores:");
            foreach (Usuario seguidor in tarea.seguidores)
            {
                imprimirUsuario(seguidor, tabs + "\t");
            }
            print(tabs + "Subtareas:");
            foreach (Tarea subtarea in tarea.tareas)
            {
                imprimirTarea(subtarea, tabs + "\t");
            }
            print(tabs + "Avances:");
            foreach (Avance avance in tarea.avances)
            {
                imprimirAvance(avance, tabs + "\t");
            }
            print();
        }

        static private void imprimirAvance(Avance avance, string tabs)
        {
            print(tabs + "Nota: " + avance.descripción);
            print(tabs + "Horas dedicadas: " + avance.HorasDedicadas.ToString());
            print(tabs + "Creador: " + (avance.creador == null ? "" : avance.creador.nombre));
            print();
        }

        static private void imprimirUsuario(Usuario user, string tabs)
        {
            print(tabs + "Nombre: " + user.nombre);
            print();
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
            print("5. Abrir tarea");
            print("6. Completar usuario");
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
