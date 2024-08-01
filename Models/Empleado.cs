using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empleados_y_Empresa.Models;

public class Empleado:Persona
{  
    public string? Posicion { get; set; }
    public double Salario { get; set; }
    public byte PorcentajeBonificacion { get; set; }

    public Empleado(string nombre, string apellido, string identificacion, byte edad, string posicion, double salario):base(nombre,apellido,identificacion,edad)
    {
        Posicion=posicion;
        Salario=salario;
        PorcentajeBonificacion=0;

    }

    public byte AsignarPorcentajeBonus(){
        Console.WriteLine($"Ingrese el porcentaje de Bonificacion del empleado {Nombre} {Apellido}");
        PorcentajeBonificacion=Convert.ToByte(Console.ReadLine());
        return PorcentajeBonificacion;
    }

    private double CalcularBonificacion(){
        double bonus=Salario*(PorcentajeBonificacion/100);
        return bonus;
    }

    public override string MostrarInfo(){
        string info= @$"
        --------------DATOS DE EMPLEADO----------------
        ID:{Id}
        Posicion: {Posicion}
        Salario Inicial: {Salario}
        Bonificacion: {CalcularBonificacion()}
        Salario: {Salario+CalcularBonificacion()}";
        return base.MostrarInfo()+info;
    }

}
