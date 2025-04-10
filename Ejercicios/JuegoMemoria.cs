using System;

namespace ProyectoConMenu.Ejercicios
{
    public class JuegoMemoria
    {
        public static void Ejecutar()
        {
            string[] palabras = { "perro", "gato", "caballo", "elefante", "jirafa" };
            Random random = new Random();
            int puntaje = 0;
            string respuesta;
            string palabraElegida;
            int intentos;

            do
            {
                // Elige una palabra aleatoria
                palabraElegida = palabras[random.Next(palabras.Length)];
                Console.WriteLine("Bienvenido al juego de memoria. Trata de recordar la palabra.");

                // Mostrar palabra elegida por un segundo
                Console.WriteLine($"La palabra es: {palabraElegida}");
                System.Threading.Thread.Sleep(1000); // Espera 1 segundo
                Console.Clear(); // Limpiar pantalla

                intentos = 0;
                bool acierto = false;

                // Intentos del jugador
                while (!acierto)
                {
                    Console.Write("Introduce la palabra que recuerdas: ");
                    respuesta = Console.ReadLine() ?? ""; // Asegura que respuesta nunca sea nula.
                    intentos++;

                    if (respuesta.ToLower() != palabraElegida)
                    {
                        Console.WriteLine("Incorrecto. Intenta nuevamente.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Correcto! Has adivinado la palabra en {intentos} intentos.");
                        acierto = true;
                        puntaje += 10; // Se le otorgan 10 puntos por acertar
                    }
                }

                // Mostrar puntaje
                Console.WriteLine($"Tu puntaje es: {puntaje}");

                // Preguntar si quiere seguir jugando
                Console.WriteLine("¿Quieres jugar otra vez? (s/n)");
                string continuar = Console.ReadLine()?.ToLower() ?? "n"; // Asegura que la entrada no sea nula.
                if (continuar != "s")
                {
                    break;
                }
                Console.Clear(); // Limpiar pantalla para el siguiente intento
            } while (true);

            Console.WriteLine("Gracias por jugar.");
        }
    }
}
