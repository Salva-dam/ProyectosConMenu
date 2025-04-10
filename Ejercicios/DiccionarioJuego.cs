using System;

namespace ProyectoConMenu.Ejercicios
{
    public class DiccionarioJuego
    {
        public static void Ejecutar()
        {
            string palabra = "abecedario";
            string respuesta;
            string definicionCorrecta = "Conjunto de letras que se utilizan para escribir un idioma.";

            Console.WriteLine("Bienvenido al juego del diccionario.");

            Console.WriteLine($"Dame la definición de la palabra: {palabra}");
            Console.Write("Tu respuesta: ");
            respuesta = Console.ReadLine() ?? ""; // Se asegura que respuesta nunca sea nula.

            // Comprobamos si la respuesta es correcta
            if (respuesta.ToLower() == definicionCorrecta.ToLower())
            {
                Console.WriteLine("¡Correcto! La definición es correcta.");
            }
            else
            {
                Console.WriteLine($"❌ Incorrecto. La definición correcta es: {definicionCorrecta}");
            }

            Console.WriteLine("Gracias por jugar.");
        }
    }
}

