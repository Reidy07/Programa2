using System;

namespace Programa2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3;
            double numero4;
            double suma;
            double producto;

            try
            {
                Console.WriteLine("Ingresar el primer numero:");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el segundo numer:");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el tercer numero:");
                numero3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresar el cuarto numero:");
                numero4 = Convert.ToDouble(Console.ReadLine());

                suma = numero1 + numero2;

                producto = numero3 * numero4;

                Console.WriteLine("La suma de los dos primeros numeros es:" + suma);
                Console.WriteLine("El producto del tercer y cuarto numero es:" + producto);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"El problema se encuantra aqui {ex.Message}");
            }
        }
    }
}