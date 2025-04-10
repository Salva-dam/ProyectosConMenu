using System;

namespace ProyectoConMenu.Ejercicios
{
    public class AdivinaElNumero
    {
        public static void Ejecutar()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); // Número entre 1 y 100
            int intento;
            int intentos = 0;

            Console.WriteLine("Bienvenido al juego: Adivina el número (entre 1 y 100)");

            do
            {
                Console.Write("Introduce un número: ");
                while (!int.TryParse(Console.ReadLine(), out intento))
                {
                    Console.Write("Por favor, ingresa un número válido: ");
                }

                intentos++;

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Has adivinado el número en {intentos} intentos.");
                }

            } while (intento != numeroAleatorio);
        }
    }
}
