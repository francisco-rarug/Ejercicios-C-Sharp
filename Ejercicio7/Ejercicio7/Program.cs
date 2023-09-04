namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;

            Console.WriteLine("Ingrese el día de su nacimiento:");
            while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
            {
                Console.WriteLine("Por favor, ingrese un día válido (entre 1 y 31).");
            }

            Console.WriteLine("Ingrese el mes de su nacimiento (como número):");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Por favor, ingrese un mes válido (entre 1 y 12).");
            }

            Console.WriteLine("Ingrese el año de su nacimiento:");
            while (!int.TryParse(Console.ReadLine(), out año) || año < 1 || año > DateTime.Now.Year)
            {
                Console.WriteLine($"Por favor, ingrese un año válido (entre 1 y {DateTime.Now.Year}).");
            }

            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacimiento;

            Console.WriteLine($"Has vivido {diferencia.Days} días hasta la fecha.");

            Console.ReadKey();

        }
    }
}



