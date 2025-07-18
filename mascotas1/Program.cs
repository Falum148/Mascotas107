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
            // PASO 13: Crear un objeto de tipo Mascota
            Mascota miMascota = new Mascota("Misha", 12, "perro", "Guau Guau");

            // PASO 14: Usar los métodos del objeto
            miMascota.MostrarInformacion(); // Mostrar información de la mascota
            miMascota.EmitirSonido(); // Emitir sonido del perro
            miMascota.SetEdad(24 + (12- 2) * 4); // Cambiar la edad de la mascota

            // PASO 15: Mascota 2
            miMascota = new Mascota("Filo", 5, "pajaro", "Pio Pío");
            miMascota.MostrarInformacion(); // Mostrar información de la mascota
            miMascota.EmitirSonido(); // Emitir sonido del pájaro
            miMascota.SetEdad(5 * 3); // Cambiar la edad de la mascota

            // PASO 16: Mascota 3
            miMascota = new Mascota("Luna", 9, "gato", "Miau");
            miMascota.MostrarInformacion(); // Mostrar información de la mascota
            miMascota.EmitirSonido(); // Emitir sonido del gato
            miMascota.SetEdad(24 + (9 - 2) * 4); // Cambiar la edad de la mascota

            Console.ReadLine(); // Pausa para ver la salida
        }
    }
}

