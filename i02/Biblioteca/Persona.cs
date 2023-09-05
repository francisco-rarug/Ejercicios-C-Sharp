using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre,  DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaDeNacimiento  = fechaDeNacimiento;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public string getDni()
        {
            return dni.ToString();
        }

        public void setFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public string getFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToString("dd/MM/yyyy");
        }

        public string calcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            if (fechaDeNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }


            return edad.ToString();
        }
        public string esMayorDeEdad()
        {
            int salida;
            string edad = calcularEdad();
            int.TryParse(edad, out salida);

            if (salida >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"NMombre: {nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Edad: {calcularEdad()}");
            sb.AppendLine($": {esMayorDeEdad()}");

            return sb.ToString();
        }
    }
}