namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int añoInicio;
            int añoFin;


            Console.WriteLine("Ingrese el año de inicio:");
            while (!int.TryParse(Console.ReadLine(), out añoInicio) || añoInicio < 0)
            {
                Console.WriteLine("Por favor ingrese devuelta el año");
            }

            Console.WriteLine("Ingrese el año de fin:");
            while(!int.TryParse(Console.ReadLine(),out añoFin)|| añoFin < añoInicio)
            {
                Console.WriteLine("Por favor, ingrese un año valido que sea mayor o igual al año de inicio");
            }

            Console.WriteLine($"Los años bisiestos entre {añoInicio} y {añoFin} son:");
            for (int año=añoInicio; año <=añoFin; año++)
            {
                if(EsBisiesto(año))
                {
                    Console.WriteLine(año);
                }
            }

            Console.ReadKey();
        }

        static bool EsBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
    }
}

        