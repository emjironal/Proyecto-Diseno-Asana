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
                    print("Importando...");
                    importarProyecto();
                    break;
                case "2":
                    agregarAvance();
                    break;
                case "3":
                    Proyecto p = DAOProyecto.consultarProyecto("1123693986642643");
                    if (p.id == "")
                    {
                        print("Jjajjajaja");
                    }
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
                case "7":
                    login();
                    break;
                case "8":
                    hacerConsulta();
                    break;
                case "9":
                    generarReporte();
                    break;
                case "10":
                    actualizarProyecto();
                    break;
                case "11":
                    consultarUsuarios();
                    break;
                case "12":
                    consultarProyectos();
                    break;
                case "13":
                    consultarTareas();
                    break;
                default:
                    print("Opción no válida");
                    break;
            }
            return false;
        }

        private static void consultarTareas()
        {
            List<Tarea> tareas = control.consultarActividades();
            foreach(Tarea t in tareas)
            {
                print(t.nombre);
            }
        }

        private static void consultarProyectos()
        {
            List<Proyecto> proyectos = control.consultarProyectos();
            foreach(Proyecto p in proyectos)
            {
                print(p.nombre);
            }
        }

        private static void consultarUsuarios()
        {
            List<Usuario> usrs = control.consultarUsuarios();
            foreach(Usuario u in usrs)
            {
                print(u.nombre);
            }
        }

        private static void generarReporte()
        {
            print("Escoja su formato");
            print("1. PDF");
            print("S. Regresar al menú principal");
            switch (input().ToUpper())
            {
                case "S":
                    return;
                case "1":
                    control.generarReportePDF();
                    print("Ingrese el path donde desea guardar el archivo");
                    string path = input();
                    print("Ingrese el nombre que le desea dar al archivo");
                    string filename = input();
                    control.guardarReportePDF(path, filename);
                    break;
                default:
                    print("Opción no válida");
                    generarReporte();
                    return;
            }
        }

        private static void hacerConsulta()
        {
            print("Seleccione el tipo de consulta");
            print("1. Miembro");
            print("2. Actividad");
            print("3. Rango de fechas");
            print("S. Regresar al menú principal");
            switch (input().ToUpper())
            {
                case "S":
                    return;
                case "1":
                    print("Proyecto: ");
                    String idProyecto = input();
                    print("Miembro: ");
                    String usuario = input();
                    object[] criterio = { null, idProyecto, usuario };
                    control.hacerConsulta("miembro",criterio);
                    break;
                case "2":
                    print("Actividad: ");
                    String idActividad = input();
                    object[] criterio2 = { null, idActividad };
                    control.hacerConsulta("actividad",criterio2);
                    break;
                case "3":
                    print("Fecha inicial: ");
                    String fchInicial = input();
                    print("Fecha final: ");
                    String fchFinal = input();
                    object[] criterio3 = { null, fchInicial,fchFinal };
                    control.hacerConsulta("fecha",criterio3);
                    break;
                default:
                    print("Consulta no válida");
                    hacerConsulta();
                    return;
            }
            foreach(Avance avance in control.dto.avances)
            {
                imprimirAvance(avance, "");
            }
        }

        private static void login()
        {
            print("Ingrese su id de usuario");
            control.dto.setUsuario(new Usuario());
            control.dto.getUsuario().id = input();
            control.login();
            if (control.dto.getUsuario() != null)
                imprimirUsuario(control.dto.getUsuario(), "");
            else
                print("No existe el usuario");
        }

        private static void completarUsuario()
        {
            Usuario usr = new Usuario();
            print("Inregese el ID del usuario por completar: ");
            usr.id = input();
            print("Ingrese el correo: ");
            usr.correo = input();
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
            control.dto.getProyecto().id = idProyecto;
            if (control.abrirProyecto())
            {
                proyecto = control.dto.getProyecto();
            }
            else
            {
                print("Error: no existe el proyecto");
                return;
            }
            
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
            print(tabs + "Administrador: " + (user.isAdministrador ? "Si" : "No"));
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
                avance.id = ""+ control.dto.getTarea().codigo + control.dto.getTarea().avances.Count;
                agregarEvidencia();
                control.agregarAvance();
            }
            else
            {
                print("No es un integer");
            }
        }

        private static void agregarEvidencia()
        {
            while (true)
            {
                print("Desea agregar evidencia: S/N");
                string decision = input();
                switch (decision.ToUpper())
                {
                    case "N":
                        return;
                    case "S":
                        try
                        {
                            print("Ingrese el path del documento");
                            string path = input();
                            byte[] doc = File.ReadAllBytes(path);
                            Evidencia evidencia = new Evidencia();
                            evidencia.documento = doc;
                            evidencia.tipo = Path.GetExtension(path);
                            control.getDTO().getAvance().evidencias.Add(evidencia);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        print("Opción no válida");
                        break;
                }
                print();
            }
        }

        static private void actualizarProyecto()
        {
            print("Ingrese el path del json del proyecto de asana");
            if (control.actualizarProyecto(input()))
            {
                print("El proyecto se actualizó correctamente");
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
            print("7. Login");
            print("8. Consulta");
            print("9. Generar reporte");
            print("10. Actualizar proyecto");
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
