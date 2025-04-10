using ProyectoConMenu.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoConMenu.Ejercicios
{
    public class AgendaContactos
    {
        private static List<Contacto> contactos = new();

        public static void Ejecutar()
        {
            string opcion;
            do
            {
                Console.WriteLine("\n📒 AGENDA DE CONTACTOS");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar por nombre");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        AgregarContacto();
                        break;
                    case "2":
                        MostrarContactos();
                        break;
                    case "3":
                        BuscarContacto();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != "0");
        }

        private static void AgregarContacto()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()!;
            Console.Write("Teléfono: ");
            string telefono = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            // Ahora creamos el contacto con los 3 parámetros
            contactos.Add(new Contacto(nombre, telefono, email));

            Console.WriteLine("✅ Contacto guardado.");
        }

        private static void MostrarContactos()
        {
            Console.WriteLine("\n📋 Lista de Contactos:");
            foreach (var c in contactos)
            {
                Console.WriteLine($"- {c.Nombre} | 📞 {c.Telefono}");
            }
        }

        private static void BuscarContacto()
        {
            Console.Write("Nombre a buscar: ");
            string nombre = Console.ReadLine()!;
            var resultado = contactos.Where(c => c.Nombre.ToLower().Contains(nombre.ToLower())).ToList();

            if (resultado.Any())
            {
                Console.WriteLine("🔍 Resultados:");
                foreach (var c in resultado)
                {
                    Console.WriteLine($"- {c.Nombre} | 📞 {c.Telefono}");
                }
            }
            else
            {
                Console.WriteLine("❌ No se encontraron coincidencias.");
            }
        }
    }
}
