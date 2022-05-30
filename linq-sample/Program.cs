//var usuario = (nombre: "William", apellido: "Castañeda");
//Console.WriteLine($"Nombre: {usuario.nombre} {usuario.apellido}");

string[] niveles = { "Basico", "Intermedio", "Avanzado" };
int totalNiveles = niveles.Count();
int totalNiveles6caracteres = niveles.Count(x => x.Length > 6);
Console.WriteLine(totalNiveles);
Console.WriteLine(totalNiveles6caracteres);

//Linq to object in extended method
var ns = niveles.Where(x => x.Length > 6).OrderBy(y => y);
foreach (var n in ns)
{
    Console.WriteLine(n);
}

//Linq to object in query mode
var qn = from n in ns where n.Length > 6 orderby n ascending select n;
foreach (var n in qn)
{
    Console.WriteLine(n);
}

List<Empleado> empleados = new List<Empleado>()
{
    new Empleado
    {
        Nombre = "William",
        Apellido = "Castañeda",
        Departamento = Departamento.Desarrollo
    },
    new Empleado
    {
        Nombre = "Carlos",
        Apellido = "Villarreal",
        Departamento = Departamento.Desarrollo
    },
    new Empleado
    {
        Nombre = "David",
        Apellido = "Muñiz",
        Departamento = Departamento.Desarrollo
    },
    new Empleado
    {
        Nombre = "Joem",
        Apellido = "Sanchez",
        Departamento= Departamento.Soporte
    },
    new Empleado
    {
        Nombre = "Juan",
        Apellido= "Tirado",
        Departamento = Departamento.Soporte
    },
    new Empleado
    {
        Nombre="Gerardo",
        Apellido="Garza",
        Departamento = Departamento.Soporte
    },
    new Empleado
    {
        Nombre="Adriana",
        Apellido="Martinez",
        Departamento=Departamento.Admin
    },
    new Empleado
    {
        Nombre="Lola",
        Apellido="Rincon",
        Departamento=Departamento.Admin
    },
    new Empleado
    {
        Nombre="Octavio",
        Apellido ="Muñiz",
        Departamento = Departamento.Admin
    },
    new Empleado
    {
        Nombre = "Angelica",
        Apellido = "Treviño",
        Departamento = Departamento.RH
    },
    new Empleado
    {
        Nombre = "Paloma",
        Apellido = "Picos",
        Departamento = Departamento.RH
    },
    new Empleado
    {
        Nombre = "Estefania",
        Apellido = "Martinez",
        Departamento = Departamento.RH
    }
};

var devs = empleados.Where(x => x.Departamento == Departamento.Desarrollo && x.Nombre.ToUpper().StartsWith("W")).OrderBy(y => y.Id);
foreach (var dev in devs)
{
    Console.WriteLine($"Nombre: {dev.Nombre} {dev.Apellido}, Departamento: {dev.Departamento}");
}

var emp = empleados.Where(x => x.Apellido.ToUpper().StartsWith("M")).OrderBy(y => y.Id).Select(u => new
{
    u.Id,
    u.Nombre,
    InicialAp = u.Apellido.Substring(0,1),
    u.Apellido,
    u.Departamento
});

var encabezado = string.Format("{0,-40}, {1,-10}, {2,-10}, {3,-10}, {4}", "ID", "Nombre", "InicialAp", "Apellido", "Departamento");
Console.WriteLine(encabezado);

foreach (var em in emp)
{
    var fila = string.Format("{0,-40}, {1,-10}, {2,-10}, {3,-10}, {4}", em.Id, em.Nombre, em.InicialAp, em.Apellido, em.Departamento);
    Console.WriteLine(fila);
}