using System;
using ProyectoConMenu.Ejercicios; // Asegúrate de importar los namespaces correctos
using ProyectoConMenu.Modelos;    // Para el acceso a la clase Contacto

namespace ProyectoConMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                // Mostrar el menú
                Console.Clear();
                Console.WriteLine("📝 Proyecto con Menú");
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Adivina el número");
                Console.WriteLine("2. Juego de Memoria");
                Console.WriteLine("3. Juego del Diccionario");
                Console.WriteLine("4. Agenda de Contactos");
                Console.WriteLine("5. Generador de Contraseñas");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = Console.ReadLine()!;

                // Switch para llamar a las opciones seleccionadas
                switch (opcion)
                {
                    case "1":
                        AdivinaElNumero.Ejecutar();
                        break;
                    case "2":
                        JuegoMemoria.Ejecutar();
                        break;
                    case "3":
                        DiccionarioJuego.Ejecutar();
                        break;
                    case "4":
                        AgendaContactos.Ejecutar();
                        break;
                    case "5":
                        GeneradorContrasena.Ejecutar();
                        break;
                    case "0":
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                // Espera antes de continuar
                if (opcion != "0")
                {
                    Console.WriteLine("\nPresiona Enter para continuar...");
                    Console.ReadLine();
                }

            } while (opcion != "0");
        }
    }
}
