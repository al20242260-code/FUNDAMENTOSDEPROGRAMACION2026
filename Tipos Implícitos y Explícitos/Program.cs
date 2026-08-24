using System;

namespace Tipos_Implícitos_y_Explícitos
{
    internal class Program
    {
        public static void Main(string[] args) {
// Variables de tipo explícito - Agregar 2 más
            sbyte  sbyteVal = 1;
            bool   boolVal  = true;
            string strVal   = "Hola";

            Console.WriteLine("Tipo de sbyteVal: " + sbyteVal.GetType());
            Console.WriteLine("Tipo de boolVal: " + boolVal.GetType());
            Console.WriteLine("Tipo de strVal: " + strVal.GetType());

            Console.WriteLine("----------------------------------");

// Variables de tipo implícito - Agregar 2 más
            var num1       = 2_000_000_000_000_000;
            var decimalVal = 1.7m;
            var doubleVal  = 1.76e52;

            Console.WriteLine("Tipo de num1: " + num1.GetType());
            Console.WriteLine("Tipo de decimalVal: " + decimalVal.GetType());
            Console.WriteLine("Tipo de doubleVal: " + doubleVal.GetType());

            Console.WriteLine("----------------------------------");

// Constantes - Agregar 2 más
            const sbyte  MIN_VALUE_SBYTE  = -128;
            const double MAX_VALUE_DOUBLE = 1.7976931348623157E+308;
            const string DIFFICULTY       = "HARD";

            Console.WriteLine("Tipo de MIN_VALUE_SBYTE: " + MIN_VALUE_SBYTE.GetType());
            Console.WriteLine("Tipo de MAX_VALUE_DOUBLE: " + MAX_VALUE_DOUBLE.GetType());
            Console.WriteLine("Tipo de DIFFICULTY: " + DIFFICULTY.GetType());

            // Lectura de pantalla
            Console.WriteLine("\n\n\n");

            Console.Write("Dame tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Dame tu apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " " + apellido);
        }
    }
}
