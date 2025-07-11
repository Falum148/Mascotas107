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
// PASO 4: Método para emitir sonido
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
// PASO 5: Método para mostrar información
Método MostrarInformacion()
    Imprimir "Nombre: " + nombre
    Imprimir "Edad: " + edad
    Imprimir "Especie: " + especie
    Imprimir "sinido: " + sonido
  Fin clase Mascota
// PASO 6: Crear un objeto de tipo Mascota
Definir clase principal Programa
   Método Main()
      Crear objeto miMascota de tipo Mascota con valores:
           - nombre = "Misha"
           - edad = "12"
           - especie = "perro"
           - sonido = "Guau Guau"
// PASO 7: Usar los métodos del objeto
           Llamar al método MostrarInformacion() del objeto miMascota
           Llamar al método  EmitirSonido(especie) del objeto miMascota
Programa Fin Clase

Fin del programa
