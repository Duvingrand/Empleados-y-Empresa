using Empleados_y_Empresa.Models;


Empresa empresa1 = new Empresa("softerINC", "Calle 30r#");

empresa1.AgregarEmpleado(new Empleado("Juan", "Pérez", "12345678A", 30, "Desarrollador", 3000));
empresa1.AgregarEmpleado(new Empleado("Ana", "García", "23456789B", 28, "Analista", 2800));
empresa1.AgregarEmpleado(new Empleado("Pedro", "Rodríguez", "34567890C", 35, "Jefe de Proyecto", 3500));
empresa1.AgregarEmpleado(new Empleado("Lucía", "Martínez", "45678901D", 40, "Diseñadora", 3200));
empresa1.AgregarEmpleado(new Empleado("Carlos", "Sánchez", "56789012E", 33, "Tester", 2900));
empresa1.AgregarEmpleado(new Empleado("María", "López", "67890123F", 29, "Marketing", 3100));
empresa1.AgregarEmpleado(new Empleado("José", "Fernández", "78901234G", 31, "Contable", 2700));
empresa1.AgregarEmpleado(new Empleado("Laura", "Gómez", "89012345H", 27, "Recursos Humanos", 3000));
empresa1.AgregarEmpleado(new Empleado("Francisco", "Vázquez", "90123456I", 38, "Soporte Técnico", 3300));
empresa1.AgregarEmpleado(new Empleado("Isabel", "Castro", "01234567J", 32, "Operaciones", 3200));

// Instanciar 10 objetos Cliente con datos de ejemplo
empresa1.AgregarCliente(new Cliente("Juan", "Pérez", "12345678A", 30, "juan.perez@example.com", "555-1234"));
empresa1.AgregarCliente(new Cliente("Ana", "Gómez", "23456789B", 25, "ana.gomez@example.com", "555-5678"));
empresa1.AgregarCliente(new Cliente("Luis", "Martínez", "34567890C", 40, "luis.martinez@example.com", "555-8765"));
empresa1.AgregarCliente(new Cliente("María", "López", "45678901D", 35, "maria.lopez@example.com", "555-4321"));
empresa1.AgregarCliente(new Cliente("Pedro", "Rodríguez", "56789012E", 28, "pedro.rodriguez@example.com", "555-3456"));
empresa1.AgregarCliente(new Cliente("Laura", "Fernández", "67890123F", 32, "laura.fernandez@example.com", "555-6543"));
empresa1.AgregarCliente(new Cliente("Carlos", "Ramírez", "78901234G", 45, "carlos.ramirez@example.com", "555-7890"));
empresa1.AgregarCliente(new Cliente("Isabel", "Morales", "89012345H", 29, "isabel.morales@example.com", "555-0987"));
empresa1.AgregarCliente(new Cliente("Jorge", "Castro", "90123456I", 38, "jorge.castro@example.com", "555-2109"));
empresa1.AgregarCliente(new Cliente("Sofía", "Vázquez", "01234567J", 27, "sofia.vazquez@example.com", "555-3210"));

Menú.MostrarMenú(empresa1);

