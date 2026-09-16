Console.WriteLine("Sistema de rendimiento Académico");

Console.WriteLine("\nIngrese la calificacion del parcial 1");
double Cal_1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nIngrese la calificacion del parcial 2");
double Cal_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nIngrese el porcentaje de asistencia (0-100): ");
double asistencia = Convert.ToDouble(Console.ReadLine());


double promedio_p = (Cal_1 + Cal_2) / 2;
double bono = asistencia * 0.05;

double calFinal = promedio_p + bono;

string estado = "";
if (asistencia < 60 || promedio_p < 70) {
    estado = "El estudiante reprueba la asignatura (promedio y/o asistencia deficiente";
}

if ( asistencia > 60 && promedio_p > 70)
{
    estado = "Aprobado || no es candidato a excelencia académica";
}

if (Cal_1 >= 90 && Cal_2 >= 90)
{
    estado = "Aprobado || es candidato a excelencia académica";
}

Console.WriteLine("\nCalificación promedio de parciales: " + promedio_p);
Console.WriteLine("\nCalificación final: " +calFinal);
Console.WriteLine("\nEstado académico: " +estado);
