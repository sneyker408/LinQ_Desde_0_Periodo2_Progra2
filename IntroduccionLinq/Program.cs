using IntroduccionLinq;

#region Introduccion 
// Esta sección introduce un ejemplo básico de cómo filtrar una lista de palabras sin usar LINQ.
// Se crea una lista de palabras y se seleccionan aquellas que tienen más de 5 letras.
// Luego, estas palabras se almacenan en una lista y se imprimen.

string[] palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocodrilo", "serpiente", "123456789" };
Console.WriteLine("Más de 5 letras");

List<string> resultado = new List<string>();

foreach (string str in palabras)
{
    if (str.Length > 5)
    {
        resultado.Add(str);
    }
}

foreach (var r in resultado)
    Console.WriteLine(r);
#endregion

#region utilizando Linq
// Esta sección muestra cómo realizar la misma operación de filtrado pero usando LINQ.
// Se seleccionan las palabras que tienen más de 8 letras y se imprimen.

Console.WriteLine("-----------------------------------------------------");
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;
foreach (var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");
#endregion

#region ListaModelos
// Aquí se definen listas de objetos de las clases Casa y Habitante.
// Estas listas se utilizarán más adelante para realizar operaciones con LINQ.

List<Casa> ListaCasas = new List<Casa>();
List<Habitante> ListaHabitantes = new List<Habitante>();
#endregion

#region listaCasa
// En esta sección se agregan varias instancias de la clase Casa a la lista ListaCasas.
// Cada instancia de Casa tiene propiedades como Id, Direccion, Ciudad, y numeroHabitaciones.

ListaCasas.Add(new Casa
{
    Id = 1,
    Direccion = "3 av Norte ArcanCity",
    Ciudad = "Gothan City",
    numeroHabitaciones = 20,
});
ListaCasas.Add(new Casa
{
    Id = 2,
    Direccion = "6 av Sur SmollVille",
    Ciudad = "Metropolis",
    numeroHabitaciones = 5,
});
ListaCasas.Add(new Casa
{
    Id = 3,
    Direccion = "Forest Hills, Queens, NY 11375",
    Ciudad = "New York"
});
#endregion

#region ListaHabitante
// Aquí se agregan varias instancias de la clase Habitante a la lista ListaHabitantes.
// Cada habitante tiene propiedades como IdHabitante, Nombre, Edad e IdCasa.

ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Bruno Diaz",
    Edad = 36,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Clark Kent.",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Peter Parker",
    Edad = 25,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 3,
    Nombre = "Tia May",
    Edad = 85,
    IdCasa = 3
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 2,
    Nombre = "Luise Lane",
    Edad = 40,
    IdCasa = 2
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Selina Kyle",
    Edad = 30,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Alfred",
    Edad = 65,
    IdCasa = 1
});
ListaHabitantes.Add(new Habitante
{
    IdHabitante = 1,
    Nombre = "Nathan Drake",
    Edad = 37,
    IdCasa = 1
});
#endregion

#region SentenciasLinQ
// Esta sección muestra el uso de LINQ para realizar consultas en la lista de habitantes.
// Se filtran los habitantes que tienen más de 40 años y se imprime su información.

IEnumerable<Habitante> ListaEdad = from ObjetoProvicional in ListaHabitantes
                                   where ObjetoProvicional.Edad > 40
                                   select ObjetoProvicional;

foreach (Habitante objetoProcicional2 in ListaEdad)
{
    Console.WriteLine(objetoProcicional2.datosHabitante());
}

// Se realiza un Join entre la lista de habitantes y la lista de casas
// para obtener los habitantes que viven en Gotham City.

IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                         join objetoTemporalCasa in ListaCasas
                                         on objetoTemporalHabitante.IdHabitante equals objetoTemporalCasa.Id
                                         where objetoTemporalCasa.Ciudad == "Gothan City"
                                         select objetoTemporalHabitante;
Console.WriteLine("----------------------------------------------------------------------------------------------");
foreach (Habitante h in listaCasaGothan)
{
    Console.WriteLine(h.datosHabitante());
}
#endregion

#region FirsthAndFirsthOrDefault
// Se muestra cómo usar First() y FirstOrDefault() para obtener el primer elemento de una lista.
// También se demuestra cómo manejar el caso donde no se encuentra ningún elemento.

Console.WriteLine("----------------------------------------------------------------------------------------------");
var primeraCasa = ListaCasas.First(); // Esto no es LINQ, es una función de IEnumerable
Console.WriteLine(primeraCasa.dameDatosCasa());

// Se obtiene el primer habitante que tiene más de 25 años utilizando LINQ.
Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
Console.WriteLine(personaEdad.datosHabitante());
Console.WriteLine("---------------------------Lo mismo pero con lambdas---------------------------------------------------------");
// Se obtiene el primer habitante que tiene más de 25 años utilizando una expresión lambda.
var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad > 25);
Console.WriteLine(Habitante1.datosHabitante());

// Ejemplo de cómo manejar un resultado nulo utilizando FirstOrDefault().
Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
if (CasaConFirsthOrDedault == null)
{
    Console.WriteLine("¡No existe! ¡No hay!");
    return;
}
Console.WriteLine("¡Existe! ¡Sí existe!");
#endregion

#region Last
// Uso de Last() para obtener el último elemento de la lista que cumple con una condición.
// También se usa LastOrDefault() para manejar posibles casos donde no se encuentra un elemento.

Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
Console.WriteLine(ultimaCasa.dameDatosCasa());
Console.WriteLine("_____________________________________________________");
var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante)
    .LastOrDefault();
if (h1 == null)
{
    Console.WriteLine("Algo falló");
    return;
}
Console.WriteLine(h1.datosHabitante());
#endregion

#region ElementAt
// Uso de ElementAt() y ElementAtOrDefault() para acceder a elementos en una posición específica de la lista.

var terceraCasa = ListaCasas.ElementAt(2);
Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

// Manejo de un posible acceso a una posición fuera de rango con ElementAtOrDefault().
var casaError = ListaCasas.ElementAtOrDefault(3);
if (casaError != null)
{
    Console.WriteLine($"La cuarta casa es {casaError.dameDatosCasa()}");
}

// Acceso al segundo habitante de la lista.
var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
Console.WriteLine($"El segundo habitante es: {segundoHabitante.datosHabitante()}");
#endregion

#region single
// Uso de Single() para obtener un único elemento que cumpla con una condición específica.
// Si la condición no es única, se lanza una excepción.

try
{
    var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad < 70);
    // Creando la misma consulta pero con LINQ
    var habitante2 = (from obtem in ListaHabitantes where obtem.Edad > 70 select obtem).SingleOrDefault();

    Console.WriteLine($"Habitante con menos de 70 años: {habitantes.datosHabitante()}");
    if (habitante2 != null) Console.WriteLine($"Habitante con más de 70 años: {habitante2.datosHabitante()}");
}
catch (Exception)
{
    Console.WriteLine("Ocurrió un error");
}
#endregion

#region typeOf
// Uso de OfType<T>() para filtrar una lista por un tipo específico.
// En este caso, se filtra una lista de empleados para obtener solo los médicos.

var listaEmpleados = new List<Empleado>() {
    new Medico(){ nombre= "Jorge Casa" },
    new Enfermero(){ nombre = "Raul Blanco" }
};

var medico = listaEmpleados.OfType<Medico>();
Console.WriteLine(medico.Single().nombre);
#endregion

#region OrderBy
// Uso de OrderBy() para ordenar una lista de habitantes por edad en orden ascendente.

var edadA = ListaHabitantes.OrderBy(x => x.Edad);
var edadAC = from vt in ListaHabitantes orderby vt.Edad select vt;
foreach (var edad in edadAC)
{
    Console.WriteLine(edad.datosHabitante());
}
#endregion

#region OrderBYDescending()
// Uso de OrderByDescending() para ordenar la lista de habitantes por edad en orden descendente.

var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
foreach (Habitante h in listaEdad)
{
    Console.WriteLine(h.datosHabitante());
}
Console.WriteLine("-------------------------------------------");
// Alternativa utilizando LINQ para ordenar en orden descendente.
var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;
foreach (Habitante h in ListaEdad2)
{
    Console.WriteLine(h.datosHabitante());
}
#endregion

#region ThenBy
// Uso de ThenBy() para ordenar una lista primero por edad y luego por nombre en orden ascendente.

var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h;

foreach (var h in edadATA)
{
    Console.WriteLine(h.datosHabitante());
}
#endregion
