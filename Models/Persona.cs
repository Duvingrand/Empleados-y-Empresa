using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public abstract class Persona
{
    public Guid Id { get; private set; }
    protected string? Nombre { get; set; }
    protected string? Apellido { get; set; }
    protected string? NumeroDeIdentificacion { get; set; }
    protected byte Edad { get; set; }

    public Persona(string nombre, string apellido, string identificacion, byte edad)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = identificacion;
        Edad = edad;

    }

    public void ModificarNombre(string nombre)
    {
        Nombre = nombre;
    }
    public void ModificarApellido(string apellido)
    {
        Apellido = apellido;
    }
    public void ModificarIdentificacion(string identificacion)
    {
        NumeroDeIdentificacion = identificacion;
    }
    public void ModificarEdad(byte edad)
    {
        Edad = edad;
    }

    public string MostrarNombre()
    {
        string name = Nombre ?? "";
        return name;
    }

    public string MostrarApellido()
    {
        string name = Apellido ?? "";
        return name;
    }

    public string MostrarIdentificacion()
    {
        string name = NumeroDeIdentificacion ?? "";
        return name;
    }

    public byte MostrarEdad()
    {
        byte name = Edad;
        return name;
    }

    public abstract string MostrarInfo();




}
