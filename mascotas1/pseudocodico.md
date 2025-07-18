Inicio del programa

//PASO 1: Definir la clase 
Definir clase Mascota  

// PASO 2: Atributos (características)
    Atributos privados:
        -nombre (cadena)
        -edad (entero)
        -especie (cadena) // puede ser "perro", "gato", "pájaro", "conejo" "pez".
        -sonido (cadena)

// PASO 3: Método constructor (nom, ed, espe, soni)
Método Constructor Mascota(nom, ed, espe, soni)
    Asignar nom a nombre
    Asignar ed a edad
    Asignar espe a especie
    Asignar soni a sonido

 //PASO 4: Propiedades públicas
    Método ObtenerNombre() : Texto
        Retornar nombre
    Fin Método

    Método ObtenerEdad() : Entero
        Retornar edad
    Fin Método

    Método ObtenerEspecie() : Texto
        Retornar especie
    Fin Método

    Método ObtenerSonido() : Texto
        Retornar sonido
    Fin Método

    //PASO 5: Método para cambiar la edad
    Método SetEdad(edadHumana : Entero)
        Si edadHumana ≥ 0 Entonces
            Escribir "Cambiando edad de " + nombre
            Escribir "Edad anterior: " + edad
            edad ← edadHumana
            Escribir "Edad humana: " + edad
        Sino
            Escribir "La edad no puede ser negativa."
        Fin Si
    Fin Método

// PASO 6: Método para emitir sonido
Metodo EmitirSonido(especie)
Si especie == "perro" entonces
   Imprimir "Guau Guau"
SiNo Si especie == "gato" entonces
   Imprimir "Miau"
SiNo Si especie == "pájaro" entonces 
   Imprimir "Pío Pío"
SiNo Si especie == "conejo" entoces
   Imprimir "Coui Coui"
SiNo Si especie == "pez" entonces 
   Imprimir "Gluo Glup"
SiNo 
   Imprimir "Desconocido"
FinMetodo

// PASO 7: Mostrar información
    Método MostrarInformacion()
        Escribir "Nombre: " + nombre
        Escribir "Edad: " + edad
        Escribir "Especie: " + especie
        Escribir "Sonido: " + sonido
    Fin Método

 // PASO 8: Edad perro
    Método CalcularEdadPerro() : Entero
        Si edad ≤ 0 Entonces
            Retornar 0
        Si edad = 1 Entonces
            Retornar 15
        Si edad = 2 Entonces
            Retornar 24
        Retornar 24 + (edad - 2) * 4
    Fin Método

    // PASO 9: Edad gato
    Método CalcularEdadGato() : Entero
        Si edad ≤ 0 Entonces
            Retornar 0
        Si edad = 1 Entonces
            Retornar 15
        Si edad = 2 Entonces
            Retornar 24
        Retornar 24 + (edad - 2) * 4
    Fin Método

    // PASO 10: Edad pájaro
    Método CalcularEdadPajaro() : Entero
        Retornar edad * 3
    Fin Método

    // PASO 11: Edad conejo
    Método CalcularEdadConejo() : Entero
        Si edad ≤ 0 Entonces
            Retornar 0
        Si edad = 1 Entonces
            Retornar 20
        Retornar 20 + (edad - 1) * 6
    Fin Método
Fin Clase

// PASO 12: Crear un objeto de tipo Mascota
Definir clase principal Programa
   Método Main()
      Crear objeto miMascota de tipo Mascota con valores:
           - nombre = "Misha"
           - edad = "12"
           - especie = "perro"
           - sonido = "Guau Guau"
// PASO 13: Usar los métodos del objeto
           Llamar al método MostrarInformacion() del objeto miMascota
           Llamar al método EmitirSonido(especie) del objeto miMascota
           Llamar al método set edad (24 + (12 - 2) *4) del objeto miMascota
// PASO 14: MASCOTA 2 Crear objeto miMascota de tipo Mascota con valores:
           - nombre = "Filo"
           - edad = "5"
           - especie = "pajaro"
           - sonido = "Pío, Pío"
           //Usar los métodos del objeto
           Llamar al método MostrarInformacion() del objeto miMascota
           Llamar al método EmitirSonido(especie) del objeto miMascota
           Llamar al método set edad (5*3) del objeto miMascota
// PASO 15: MASCOTA 3 Crear objeto miMascota de tipo Mascota con valores:
           - nombre = "Luna"
           - edad = "9"
           - especie = "gato"
           - sonido = "Miau Miau"
         //Usar los métodos del objeto
           Llamar al método MostrarInformacion() del objeto miMascota
           Llamar al método EmitirSonido(especie) del objeto miMascota
           Llamar al método set edad (24 + (9 - 2) *4) del objeto miMascota


Programa Fin Clase

Fin del programa
