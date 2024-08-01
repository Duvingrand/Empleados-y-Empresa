using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public class Persona
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }

    public Persona(string nombre, string apellido, string identificacion, byte edad)
    {
        Nombre=nombre;
        Apellido=apellido;
        NumeroDeIdentificacion=identificacion;
        Edad=edad;
        
    }

    public virtual string MostrarInfo(){
        string info=$@"----------------------------------------------------------------------
        
        Nombre: {Nombre} {Apellido}
        ID personal: {NumeroDeIdentificacion}
        Edad: {Edad}
        ";
        return info;
    }

}
