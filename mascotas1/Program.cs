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

        // PASO 4: Método para emitir sonido
        public void EmitirSonido()
        {
            if (especie == "perro")
                Console.WriteLine("Guau Guau");
            else if (especie == "gato")
                Console.WriteLine("Miau");
            else if (especie == "pájaro")
                Console.WriteLine("Pío Pío");
            else if (especie == "conejo")
                Console.WriteLine("Coui Coui");
            else if (especie == "pez")
                Console.WriteLine("Gluo Glup");
            else
                Console.WriteLine("Desconocido");
        }

        // PASO 5: Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Sonido: " + sonido);
        }
    }

    // PASO 6: Clase principal
    class Programa
    {
        static void Main(string[] args)
        {
            // PASO 7: Crear un objeto de tipo Mascota
            Mascota miMascota = new Mascota("Misha", 12, "perro", "Guau Guau");

            // Usar los métodos del objeto
            miMascota.MostrarInformacion();
            miMascota.EmitirSonido();

            Console.ReadLine(); // Pausa para ver la salida
        }
    }
}

