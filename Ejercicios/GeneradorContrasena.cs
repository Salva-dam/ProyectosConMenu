using System;

namespace ProyectoConMenu.Ejercicios
{
    public class GeneradorContrasena
    {
        public static void Ejecutar()
        {
            Console.WriteLine("🔐 Generador de Contraseñas Seguras");

            int longitud;
            Console.Write("👉 ¿Longitud de la contraseña? (Ej: 12): ");
            while (!int.TryParse(Console.ReadLine(), out longitud) || longitud <= 0)
            {
                Console.Write("❌ Ingresa un número válido: ");
            }

            Console.Write("¿Incluir letras mayúsculas? (s/n): ");
            bool incluirMayus = Console.ReadLine()!.ToLower() == "s";

            Console.Write("¿Incluir letras minúsculas? (s/n): ");
            bool incluirMinus = Console.ReadLine()!.ToLower() == "s";

            Console.Write("¿Incluir números? (s/n): ");
            bool incluirNumeros = Console.ReadLine()!.ToLower() == "s";

            Console.Write("¿Incluir símbolos? (s/n): ");
            bool incluirSimbolos = Console.ReadLine()!.ToLower() == "s";

            string caracteres = "";

            if (incluirMayus) caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (incluirMinus) caracteres += "abcdefghijklmnopqrstuvwxyz";
            if (incluirNumeros) caracteres += "0123456789";
            if (incluirSimbolos) caracteres += "!@#$%^&*()-_=+[]{};:,.<>?";

            if (string.IsNullOrEmpty(caracteres))
            {
                Console.WriteLine("⚠️ Debes seleccionar al menos una opción de caracteres.");
                return;
            }

            Random random = new Random();
            string contrasena = new string(Enumerable.Repeat(caracteres, longitud)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            Console.WriteLine($"\n🔐 Tu contraseña generada: {contrasena}");
        }
    }
}
