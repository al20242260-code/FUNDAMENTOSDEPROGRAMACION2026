using System;

namespace _31_08_26V2
{
    internal class Program
    {
        public static void Main(string[] args) {
            // See https://aka.ms/new-console-template for more information
// Crear un programa que declare un entero y que imprima la vida de un jugador


            Console.WriteLine("Dame la vida del jugador");
            int hp = 50;


            Console.WriteLine(hp = 50);


// Pedir mp y si está mal, decir error


            Console.WriteLine("Dame el maná del jugador");
            int mp = 8000;


// 1. Pedir mp
            Console.Write("Dame el mp: ");
            var  mpStr      = Console.ReadLine();
// 2. Validar que sea un número entero
            bool mpEsValido = int.TryParse(mpStr, out mp);
// 3. Si es entero, muestro la tabla
// 4. Si no es entero, mostrar mensaje de error


            if (mpEsValido == true)
            {
                Console.WriteLine("HP: " + mp);
                // Pide el nombre del jugador e imprimelo
                Console.WriteLine("Dame el Nombre del Jugador");
                string Nombre = Console.ReadLine();


// Pide el apodo del jugador e imprimelo entre comillas dobles
                Console.WriteLine("Dame el apodo del jugador");
                string Apodo = Console.ReadLine();


                Console.WriteLine("----------------------------------");


                Console.Write (Nombre);
                Console.WriteLine ("  \"" + Apodo + "\" ");
                Console.WriteLine("hp = " + hp);
                Console.WriteLine("mp = " + mp);




            }

            else
            {
                Console.WriteLine("error");}

        }
    }
}
