namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorhoras;
            string nombre;
            int antiguedad;
            int cantidadHoras;
            int totalhoras;
            int suma;
            int descuentos;
            int neto;

            Console.WriteLine("Ingrese la cantidad de empleados: ");
            int empleados = int.Parse(Console.ReadLine());

            for (int i = 0; i < empleados; i++)
            {
                Console.WriteLine($"Empleado {i + 1}:");

                Console.WriteLine("Ingrese el valor de horas: ");
                valorhoras = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese los años de antigüedad que tiene el empleado: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes: ");
                cantidadHoras = int.Parse(Console.ReadLine());

                totalhoras = valorhoras * cantidadHoras;
                suma = totalhoras + (antiguedad * 150);
                descuentos = (suma * 13) / 100;
                neto = suma - descuentos;

                Console.WriteLine($"Recibo del empleado {nombre}:");
                Console.WriteLine($"Antigüedad: {antiguedad} años");
                Console.WriteLine($"Valor por hora: ${valorhoras}");
                Console.WriteLine($"Total en bruto: ${suma}");
                Console.WriteLine($"Descuentos: ${descuentos}");
                Console.WriteLine($"Total neto a cobrar: ${neto}");
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}