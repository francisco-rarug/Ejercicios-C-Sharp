namespace Prueba01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Ingresa un número:");

            if (double.TryParse(Console.ReadLine(), out numero))
            {
                while (numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    if (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        numero = -1; 
                    }
                }

                double cuadrado = Math.Pow(numero, 2);
                double cubo = Math.Pow(numero, 3);

                Console.WriteLine($"El cuadrado de {numero} es {cuadrado}");
                Console.WriteLine($"El cubo de {numero} es {cubo}");
            }
            else
            {
                Console.WriteLine("No ingresaste un número válido.");
            }

            Console.ReadKey();
        }
    }
}
