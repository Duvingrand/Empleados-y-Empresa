using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public class Empresa
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }
    public List<Cliente> ListaClientes { get; set; }

    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaEmpleados = new List<Empleado>();
        ListaClientes = new List<Cliente>();
    }

    //--------------------------------------------------------------------------------------------------------
    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }
    //--------------------------------------------------------------------------------------------------------
    public void EliminarEmpleado()
    {
        Console.Clear();
        Console.Write("Ingrese los nombres (solo nombres) del empleado a eliminar: ");
        string nombres = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para nombre.");
        Console.Write("ingrese los apellidos del usuario a eliminar: ");
        string apellidos = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para apellido.");
        string fullname = $"{nombres} {apellidos}";
        Console.Clear();
        Console.WriteLine($"Buscando a {fullname}");

        var empleadoAEliminar = ListaEmpleados.Find(e => $"{e.MostrarNombre()} {e.MostrarApellido()}" == fullname);

        if (empleadoAEliminar != null)
        {
            ListaEmpleados.Remove(empleadoAEliminar);
            Console.WriteLine($"{fullname} eliminado correctamente");
        }
        else
        {
            Console.WriteLine($"No se encontró a {fullname}");
        }
        Console.ReadKey();
    }

        public void EliminarCliente()
    {
        Console.Clear();
        Console.Write("Ingrese los nombres (solo nombres) del cliente a eliminar: ");
        string nombres = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para nombre.");
        Console.Write("ingrese los apellidos del usuario a eliminar: ");
        string apellidos = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para apellido.");
        string fullname = $"{nombres} {apellidos}";
        Console.Clear();
        Console.WriteLine($"Buscando a {fullname}");

        var clienteAEliminar = ListaClientes.Find(e => $"{e.MostrarNombre()} {e.MostrarApellido()}" == fullname);

        if (clienteAEliminar != null)
        {
            ListaClientes.Remove(clienteAEliminar);
            Console.WriteLine($"{fullname} eliminado correctamente");
        }
        else
        {
            Console.WriteLine($"No se encontró a {fullname}");
        }
        Console.ReadKey();
    }
    //--------------------------------------------------------------------------------------------------------
    public void MostrarEmpleados()
    {
        foreach (var e in ListaEmpleados)
        {
            Console.WriteLine(e.MostrarInfo());
            Console.WriteLine();
        }
    }

        public void MostrarClientes()
    {
        foreach (var e in ListaClientes)
        {
            Console.WriteLine(e.MostrarInfo());
            Console.WriteLine();
        }
    }
    //--------------------------------------------------------------------------------------------------------
    public void ActualizarEmpleado()
    {
        Console.Clear();
        Console.WriteLine("ACTUALIZAR EMPLEADO POR NUMERO DE IDENTIFICACION");
        Console.Write("Ingrese el numero de identificacion: ");
        string identificacion = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para número de identificación.");

        var personaEncontrado = ListaEmpleados.Find(e => e.MostrarIdentificacion() == identificacion);

        if (personaEncontrado != null)
        {
            bool editar = true;
            while (editar)
            {
                Console.Clear();
                Console.WriteLine($"Seleccione la propiedad que desea editar de {personaEncontrado.MostrarNombre()} {personaEncontrado.MostrarApellido()}:");
                Console.WriteLine("1. Nombre ");
                Console.WriteLine("2. Apellido");
                Console.WriteLine("3. Numero de identificacion");
                Console.WriteLine("4. Edad");
                Console.WriteLine("5. Posicion");
                Console.WriteLine("6. Porcentaje de Bonificacion");
                Console.WriteLine("7. Salario");
                Console.WriteLine("8. Salir");
                Console.Write("Ingrese el número de la opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese el nuevo nombre: ");
                        string nombre = Console.ReadLine()?? "";
                        personaEncontrado.ModificarNombre(nombre);
                        break;

                    case "2":
                        Console.Write("Ingrese el nuevo apellido: ");
                        string apellido = Console.ReadLine()?? "";
                        personaEncontrado.ModificarNombre(apellido);
                        break;

                    case "3":
                        Console.Write("Ingrese el nuevo Numero de Identificacion: ");
                        string iden = Console.ReadLine()?? "";
                        personaEncontrado.ModificarNombre(iden);
                        break;

                    case "4":
                        Console.WriteLine("Ingrese la nueva Edad: ");
                        byte edad = Convert.ToByte(Console.ReadLine());
                        personaEncontrado.ModificarEdad(edad);
                        break;

                    case "5":
                        Console.WriteLine("Ingrese la nueva Posición: ");
                        personaEncontrado.Posicion = Console.ReadLine();
                        break;

                    case "6":
                        personaEncontrado.AsignarPorcentajeBonus();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese el nuevo salario: ");
                        personaEncontrado.Salario = Convert.ToDouble(Console.ReadLine());
                        break;

                    case "8":
                        editar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }

        }
        else
        {
            Console.WriteLine($"No se encontró un empleado con identificación {identificacion}");
        }
        Console.ReadKey();

    }

    //--------------------------------------------------------------------------------------------------------

    public void BuscarEmpleado()
    {
        Console.Clear();
        Console.WriteLine("BUSCAR EMPLEADO POR NUMERO DE IDENTIFICACION");
        Console.Write("Ingrese el numero de identificacion: ");
        string identificacion = Console.ReadLine() ?? throw new InvalidOperationException("Entrada inválida para número de identificación.");

        var personaEncontrado = ListaEmpleados.Find(e => e.MostrarIdentificacion() == identificacion);

        if (personaEncontrado != null)
        {
            Console.WriteLine(personaEncontrado.MostrarInfo());
        }
        else
        {
            Console.WriteLine($"No se encontró un empleado con identificación {identificacion}");
        }
        Console.ReadKey();
    }
    //--------------------------------------------------------------------------------------------------------
    public void MostrarEmpleadosPorCargo()
    {

    }
}


