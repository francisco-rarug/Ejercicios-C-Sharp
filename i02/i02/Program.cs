using Biblioteca;

namespace i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona uno = new("francisco", new DateTime(2003 , 12 , 17), 45280820);
            Console.WriteLine(uno.Mostrar());

            Persona dos = new("thiago", new DateTime(2004,04,09), 01010101);
            Console.WriteLine(dos.Mostrar());

            Persona tres = new("nico", new DateTime(2009,12,09), 45280820);
            Console.WriteLine(tres.Mostrar());
        }
    }
}