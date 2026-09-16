using System.Diagnostics.Tracing;

Console.WriteLine("Identificador Simple del Día de la Semana");

Console.WriteLine("Ingrese un numero del 1 al 7:");
int numeroid = Convert.ToInt32(Console.ReadLine());

int diaSiguiente = numeroid + 1;

string diaHoy = numeroid switch
{
    1 => "Lunes",
    2 => "Martes",
    3 => "Miercoles",
    4 => "Jueves",
    5 => "Viernes",
    6 => "Sabado",
    7 => "Domingo",
    _ => "No hay equivalencia"
};

Console.WriteLine("El dia de hoy es: "+diaHoy );


