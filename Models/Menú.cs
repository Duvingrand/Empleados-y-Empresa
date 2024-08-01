using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public static class Menú
{
    public static void MostrarMenú(Empresa empresa1)
    {
        int option = 0;

        while (option != 7)
        {
            // Mostrar el menú
            Console.Clear(); // Limpiar la consola para una mejor visualización
            Console.WriteLine("Menú Principal");
            Console.WriteLine("1. Agregar Empleado");
            Console.WriteLine("2. Agregar Cliente");
            Console.WriteLine("3. Eliminar Empleado");
            Console.WriteLine("4. Eliminar Cliente");
            Console.WriteLine("5. Mostrar Todos los empleados");
            Console.WriteLine("6. Mostrar Todos los clientes");
            Console.WriteLine("7. Actualizar empleado");
            Console.WriteLine("8. Buscar Empleado por Documento");
            Console.WriteLine("9. Mostrar Empleados por cargo");
            Console.WriteLine("10. Salir");
            Console.Write("Seleccione una opción (1-10): ");

            // Leer la opción del usuario
            string input = Console.ReadLine() ?? "";
            bool isNumeric = int.TryParse(input, out option);

            // Verificar si la opción es válida
            if (!isNumeric || option < 1 || option > 10)
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 10.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            // Ejecutar acción según la opción seleccionada
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Agregar Empleado");
                    empresa1.AgregarEmpleado(empresa1.CrearEmpleado());

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Agregar Cliente");
                    empresa1.AgregarCliente(empresa1.CrearCliente());

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Eliminar Empleado");
                    empresa1.EliminarEmpleado();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Eliminar Cliente");
                    empresa1.EliminarCliente();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Mostrar Todos los empleados");
                    empresa1.MostrarEmpleados();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Mostrar Todos los empleados");
                    empresa1.MostrarClientes();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Actualizar empleado");
                    empresa1.ActualizarEmpleado();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Buscar Empleado por Documento");
                    empresa1.BuscarEmpleado();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la Opción Mostrar Empleados por cargo");
                    empresa1.MostrarEmpleadosPorCargo();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Saliendo...");
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de volver a mostrar el menú
            if (option != 7)
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

}
