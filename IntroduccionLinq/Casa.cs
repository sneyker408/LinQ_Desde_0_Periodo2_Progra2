using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Casa dentro del espacio de nombres IntroduccionLinq
    public class Casa
    {
        // Propiedad Id para almacenar un identificador único para cada instancia de Casa
        public int Id { get; set; }

        // Propiedad Direccion para almacenar la dirección de la casa
        public string Direccion { get; set; }

        // Propiedad Ciudad para almacenar la ciudad donde se ubica la casa
        public string Ciudad { get; set; }

        // Propiedad numeroHabitaciones para almacenar el número de habitaciones de la casa
        public int numeroHabitaciones { get; set; }

        // Método dameDatosCasa para devolver una cadena con la información de la casa
        public string dameDatosCasa()
        {
            // El método retorna una cadena que incluye la dirección, la ciudad y el número de habitaciones de la casa
            return $"Dirección: {Direccion}, Ciudad: {Ciudad}, Número de habitaciones: {numeroHabitaciones}";
        }
    }
}
