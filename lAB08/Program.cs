using System;
namespace AnalisisNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0, n, p; int a = 0, r = 0;
            Console.WriteLine("--- Analisis de Notas de 10 Estudiantes ---");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese la nota " + i + ": ");
                if (double.TryParse(Console.ReadLine(), out n))
                {
                    s += n;
                    if (n >= 61) { a++; } else { r++; }
                }
                else { s += 0; r++; }
            }
            p = s / 10;
            Console.WriteLine("Promedio: " + p.ToString("F2"));
            Console.WriteLine("Aprobados: " + a);
            Console.WriteLine("Reprobados: " + r);
            Console.WriteLine("Presione una tecla...");
            Console.ReadKey();
        }
    }
}