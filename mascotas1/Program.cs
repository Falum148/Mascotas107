using System;

namespace MascotasApp
{
    // PASO 1: Definir la clase
    class Mascota
    {
        // PASO 2: Atributos privados
        private string nombre;
        private int edad;
        private string especie;
        private string sonido;

        // PASO 3: Constructor
        public Mascota(string nom, int ed, string espe, string soni)
        {
            nombre = nom;
            edad = ed;
            especie = espe;
            sonido = soni;
        }

        // PASO 4: Propiedades públicas para acceder a los atributos
        public string Nombre { get { return nombre; } }
        public int Edad { get { return edad; } }
        public string Especie { get { return especie; } }
        public string Sonido { get { return sonido; } }

        // PASO 5: Método para cambiar la edad
        public void SetEdad(int edadHumana)
        {
            if (edadHumana >= 0)
            {
                Console.WriteLine($"\nCambiando edad de {nombre}...");

                Console.WriteLine($"Edad anterior: {edad} años");
                edad = edadHumana;
                Console.WriteLine($"Edad humana: {edad} años");
            }
            else
            {
                Console.WriteLine("La edad no puede ser negativa.");
            }
        }

        // PASO 6: Método para emitir sonido
        public void EmitirSonido()
        {
            if (especie == "perro")
                Console.WriteLine("Guau Guau");
            else if (especie == "gato")
                Console.WriteLine("Miau");
            else if (especie == "pajaro")
                Console.WriteLine("Pío Pío");
            else if (especie == "conejo")
                Console.WriteLine("Coui Coui");
            else if (especie == "pez")
                Console.WriteLine("Glup Glup");
            else
                Console.WriteLine("Desconocido");
        }

        // PASO 7: Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Sonido: " + sonido);
        }

        // PASO 8: Método para calcular edad de un perro
        private int CalcularEdadPerro()
        {
            if (edad <= 0) return 0;
            if (edad == 1) return 15;
            if (edad == 2) return 24;
            return 24 + (edad - 2) * 4;
        }

        // PASO 9: Método para calcular la edad de un gato
        private int CalcularEdadGato()
        {
            if (edad <= 0) return 0;
            if (edad == 1) return 15;
            if (edad == 2) return 24;
            return 24 + (edad - 2) * 4;
        }

        //PASO 10: Método para calcular la edad de un pájarO
        private int CalcularEdadPajaro()
        {
            return edad * 3;
        }

        //PASO 11: Método para calcular la edad de un conejo
        private int CalcularEdadConejo()
        {
            if (edad <= 0) return 0;
            if (edad == 1) return 20;
            return 20 + (edad - 1) * 6;
        }
    }
    
    // PASO 12: Clase principal
    class Programa
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al programa de mascotas!");
            Console.WriteLine("por favor, elige una mascota para mostrar su información:");
            Console.WriteLine("1. Misha (perro)");
            Console.WriteLine("2. Luna (gato)");
            Console.WriteLine("3. Filo (pájaro)");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear(); // Limpiar la consola

            // Validar la opción elegida
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has elegido a Misha, la perra.");

                    // PASO 13: Crear un objeto de tipo Mascota
                    Mascota miMascota = new Mascota("Misha", 12, "perro", "Guau Guau");

                    // PASO 14: Usar los métodos del objeto
                    miMascota.MostrarInformacion(); // Mostrar información de la mascota
                    miMascota.EmitirSonido(); // Emitir sonido del perro
                    miMascota.SetEdad(24 + (12 - 2) * 4); // Cambiar la edad de la mascota

                    break;


                case 2:
                    Console.WriteLine("Has elegido a Luna, la gata.");

                    // PASO 16: Mascota 3
                    miMascota = new Mascota("Luna", 9, "gato", "Miau");

                    miMascota.MostrarInformacion(); // Mostrar información de la mascota
                    miMascota.EmitirSonido(); // Emitir sonido del gato
                    miMascota.SetEdad(24 + (9 - 2) * 4); // Cambiar la edad de la mascota

                    break;


                case 3:
                    Console.WriteLine("Has elegido a Filo, el pájaro.");

                    // PASO 15: Mascota 2
                    miMascota = new Mascota("Filo", 5, "pajaro", "Pio Pío");

                    miMascota.MostrarInformacion(); // Mostrar información de la mascota
                    miMascota.EmitirSonido(); // Emitir sonido del pájaro
                    miMascota.SetEdad(5 * 3); // Cambiar la edad de la mascota

                    break;

                default:
                    Console.WriteLine("Opción no válida. Saliendo del programa.");
                    return;
            }

            Console.WriteLine("\nGracias por usar el programa de mascotas!");
            Console.WriteLine("deseas ver la información de otra mascota? (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "s")
            {
                Console.Clear(); //limpiar la consola
                Main(args); // Llamar al método Main para reiniciar el programa
            }
            else
            {
                Console.WriteLine("Saliendo del programa...");
                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey(); // Esperar a que el usuario presione una tecla
            }
        }
    }
}

