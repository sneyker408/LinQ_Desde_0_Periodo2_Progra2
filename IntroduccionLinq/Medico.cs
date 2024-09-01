using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase Medico que hereda de la clase Empleado
    public class Medico : Empleado
    {
        // Propiedad nombre para almacenar el nombre del médico
        // Esta propiedad sobrescribe la propiedad 'nombre' de la clase base (Empleado)
        public string nombre { get; set; }
    }
}
