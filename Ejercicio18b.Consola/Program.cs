using System.Timers;

namespace Ejercicio18b.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Grado;
            double Multiplicacion;

            Console.Write("Ingrese el valor del grado: ");
            Grado= int.Parse(Console.ReadLine());
            
            Multiplicacion = Grado * 0.0174532925;

            if (Grado > 0)
            {
                Console.Write($"El grado pasado a radian es {Multiplicacion}");
            }else
            {
                Console.Write("El Grado debe ser positivo");
            }
        }
    }
}