using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string apellido, string identificacion, byte edad, string email, string telefono) : base(nombre, apellido, identificacion, edad)
    {
        Email = email;
        Telefono = telefono;
    }

    public override string MostrarInfo()
    {
        string info = @$"
        --------------CONTACTO----------------
        Correo: {Email}
        Telefono: {Telefono}";
        return base.MostrarInfo() + info;
    }

}
