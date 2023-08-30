namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.WriteLine("Ingrese la altura de la pirámide:");
            while (!int.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo para la altura.");
            }

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}
