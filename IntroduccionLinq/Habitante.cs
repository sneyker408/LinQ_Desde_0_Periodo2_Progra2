using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Habitante dentro del espacio de nombres IntroduccionLinq
    public class Habitante
    {
        // Propiedad IdHabitante para almacenar un identificador único para cada habitante
        public int IdHabitante { get; set; }

        // Propiedad Nombre para almacenar el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad Edad para almacenar la edad del habitante
        public int Edad { get; set; }

        // Propiedad IdCasa para almacenar el identificador de la casa donde vive el habitante
        public int IdCasa { get; set; }

        // Método datosHabitante para devolver una cadena con la información del habitante
        public string datosHabitante()
        {
            // El método retorna una cadena que incluye el nombre, la edad y el identificador de la casa del habitante
            return $"Soy {Nombre} con edad de {Edad} años, vivo en la casa con Id {IdCasa}";
        }
    }
}
