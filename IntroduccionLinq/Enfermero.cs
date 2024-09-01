using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Enfermero que hereda de la clase Empleado
    public class Enfermero : Empleado
    {
        // Propiedad nombre para almacenar el nombre del enfermero
        // Esta propiedad sobrescribe la propiedad 'nombre' de la clase base (Empleado)
        public string nombre { get; set; }
    }
}
