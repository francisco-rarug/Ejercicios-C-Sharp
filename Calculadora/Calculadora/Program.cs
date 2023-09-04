namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int calculo = 0;
            string flag;
            string opcion=null;

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                Console.WriteLine("Ingrese el segundo numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

                Console.WriteLine("Ingrese la operacion a realizar (suma, resta, division, multiplicacion): ");
                flag = Console.ReadLine();

                switch (flag)
                {
                    case "suma":
                        calculo = numero1 + numero2;
                        break;

                    case "resta":
                        calculo = numero1 - numero2;
                        break;

                    case "division":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: División por cero.");
                            continue;
                        }
                        calculo = numero1 / numero2;
                        break;

                    case "multiplicacion":
                        calculo = numero1 * numero2;
                        break;

                    default:
                        Console.WriteLine("Error, esa operacion es incorrecta.");
                        continue;
                }

                Console.WriteLine($"El resultado de la {flag} es {calculo}");

                Console.WriteLine("¿Quiere seguir operando? (s/n)");
                opcion = Console.ReadLine();

            } while (opcion.ToLower()=="s");

            Console.WriteLine("Hasta la proxima!!!");
        }
    }
}
