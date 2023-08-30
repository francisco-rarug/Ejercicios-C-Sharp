namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorIngresado;
            string buffer;
            bool estado;
            int contador = 0;
            int acumuladorIngresos = 0;
            float promedio;
            int minIngresado = int.MaxValue;
            int maxIngresado = int.MinValue;

            do
            {
                Console.WriteLine("Dame un numero");
                buffer = Console.ReadLine();
                estado = int.TryParse(buffer, out valorIngresado);

                while (!estado)
                {
                    Console.WriteLine("Dame un numero de nuevo...");
                    buffer = Console.ReadLine();
                    estado = int.TryParse(buffer, out valorIngresado);
                }
                acumuladorIngresos += valorIngresado;

                if (contador == 0)
                {
                    minIngresado = valorIngresado;
                    maxIngresado = valorIngresado;
                }
                else
                {
                    if (valorIngresado > maxIngresado)
                    {
                        maxIngresado = valorIngresado;
                    }
                    else
                    {
                        if (valorIngresado < minIngresado)
                        {
                            minIngresado = valorIngresado;
                        }
                    }
                }

                contador++;
                Console.WriteLine(valorIngresado.ToString());
            } while (contador < 5);

            if (contador != 0)
            {
                promedio = (float)acumuladorIngresos / contador;
                Console.WriteLine("PROMEDIO: {0}", promedio.ToString());
            }

            Console.WriteLine("MAXIMO: {0}\nMINIMO: {1}", maxIngresado.ToString(), minIngresado.ToString());
        }
    }
}