#region ejemplo de tulpa
//var usuario = (nombre: "William", apellido: "Castañeda");
//Console.WriteLine($"Nombre: {usuario.nombre} {usuario.apellido}");
#endregion 

#region ejemplo de metodo extendido
//string[] niveles = { "Basico", "Intermedio", "Avanzado" };
//int totalNiveles = niveles.Count();
//int totalNiveles6caracteres = niveles.Count(x => x.Length > 6);
//Console.WriteLine(totalNiveles);
//Console.WriteLine(totalNiveles6caracteres);
#endregion

#region ejemplo simple de linq usando metodo extendido y modo consulta
////Linq to object in extended method
//var ns = niveles.Where(x => x.Length > 6).OrderBy(y => y);
//foreach (var n in ns)
//{
//    Console.WriteLine(n);
//}

////Linq to object in query mode
//var qn = from n in ns where n.Length > 6 orderby n ascending select n;
//foreach (var n in qn)
//{
//    Console.WriteLine(n);
//}
#endregion

List<Empleado> empleados = new List<Empleado>()
{
    new Empleado
    {
        Nombre = "William",
        Apellido = "Castañeda",
        Departamento = Departamento.Desarrollo,
        Edad = 37
    },
    new Empleado
    {
        Nombre = "Carlos",
        Apellido = "Villarreal",
        Departamento = Departamento.Desarrollo,
        Edad = 35
    },
    new Empleado
    {
        Nombre = "David",
        Apellido = "Muñiz",
        Departamento = Departamento.Desarrollo,
        Edad = 31
    },
    new Empleado
    {
        Nombre = "Joem",
        Apellido = "Sanchez",
        Departamento= Departamento.Soporte,
        Edad = 35
    },
    new Empleado
    {
        Nombre = "Juan",
        Apellido= "Tirado",
        Departamento = Departamento.Soporte,
        Edad = 42
    },
    new Empleado
    {
        Nombre="Gerardo",
        Apellido="Garza",
        Departamento = Departamento.Soporte,
        Edad = 46
    },
    new Empleado
    {
        Nombre="Adriana",
        Apellido="Martinez",
        Departamento=Departamento.Admin,
        Edad = 36
    },
    new Empleado
    {
        Nombre="Lola",
        Apellido="Rincon",
        Departamento=Departamento.Admin,
        Edad = 34
    },
    new Empleado
    {
        Nombre="Octavio",
        Apellido ="Muñiz",
        Departamento = Departamento.Admin,
        Edad = 50
    },
    new Empleado
    {
        Nombre = "Angelica",
        Apellido = "Treviño",
        Departamento = Departamento.RH,
        Edad = 49
    },
    new Empleado
    {
        Nombre = "Paloma",
        Apellido = "Picos",
        Departamento = Departamento.RH,
        Edad = 45
    },
    new Empleado
    {
        Nombre = "Estefania",
        Apellido = "Martinez",
        Departamento = Departamento.RH,
        Edad = 41
    }
};

#region test1
//var devs = empleados.Where(x => x.Departamento == Departamento.Desarrollo && x.Apellido.ToUpper().StartsWith("W")).OrderBy(y => y.Id);
//foreach (var dev in devs)
//{
//    Console.WriteLine($"Nombre: {dev.Nombre} {dev.Apellido}, Departamento: {dev.Departamento}");
//}

//var emp = empleados.Where(x => x.Apellido.ToUpper().StartsWith("M")).OrderBy(y => y.Id).Select(u => new
//{
//    u.Id,
//    u.Nombre,
//    InicialAp = u.Apellido.Substring(0,1),
//    u.Apellido,
//    u.Departamento
//});

//var encabezado = string.Format("{0,-40}, {1,-10}, {2,-10}, {3,-10}, {4}", "ID", "Nombre", "InicialAp", "Apellido", "Departamento");
//Console.WriteLine(encabezado);

//foreach (var em in emp)
//{
//    var fila = string.Format("{0,-40}, {1,-10}, {2,-10}, {3,-10}, {4}", em.Id, em.Nombre, em.InicialAp, em.Apellido, em.Departamento);
//    Console.WriteLine(fila);
//}
#endregion

#region test2
//var emps = empleados
//    .Where(x => x.Departamento == Departamento.Desarrollo || x.Departamento == Departamento.Soporte)
//    .Where(y => y.Nombre.StartsWith("J")).OrderByDescending(z => z.Nombre);

//var encabezado = string.Format("{0,-40} {1,-10} {2,-10} {3,-10}", "ID", "Nombre", "Apellido", "Departamento");
//Console.WriteLine(encabezado);
//foreach (var emp in emps)
//{
//    var fila = string.Format("{0,-40} {1,-10} {2,-10} {3,-10}", emp.Id, emp.Nombre, emp.Apellido, emp.Departamento);
//    Console.WriteLine(fila);
//}

//Console.WriteLine($"\n");
//var emps2 = from e in empleados
//            where (e.Departamento == Departamento.Desarrollo || e.Departamento == Departamento.Soporte) && e.Nombre.StartsWith("J")
//            orderby e.Nombre ascending
//            select new { e.Id, e.Nombre, e.Apellido, e.Departamento };

//foreach (var emp in emps2)
//{
//    var fila = string.Format("{0,-40} {1,-10} {2,-10} {3,-10}", emp.Id, emp.Nombre, emp.Apellido, emp.Departamento);
//    Console.WriteLine(fila);
//}
#endregion

#region test3
//var emps = empleados.Where(x => x.Nombre.Length == empleados.OrderBy(y => y.Apellido.Length).Select(y => y.Apellido.Length).First());
//var encabezado = string.Format("{0,-10} {1,-10}", "Nombre", "Apellido");
//Console.WriteLine(encabezado);
//foreach (var emp in emps)
//{
//    var fila = string.Format("{0,-10} {1,-10}", emp.Nombre, emp.Apellido);
//    Console.WriteLine(fila);
//}

//Console.WriteLine("\n");
//var emps2 = from emp in emps
//            where emp.Nombre.Length == (from sq in empleados orderby sq.Apellido.Length select sq.Apellido.Length).First()
//            select emp;
//foreach (var emp in emps)
//{
//    var fila = string.Format("{0,-10} {1,-10}", emp.Nombre, emp.Apellido);
//    Console.WriteLine(fila);
//}
#endregion

#region test4

////Skip
//ImprimirEmpleados(empleados);
//var filtro = empleados.Skip(2);
//ImprimirEmpleados(filtro);

////Reverse
//var filtro = empleados.Where(x => x.Edad < 40);
//ImprimirEmpleados(filtro);
//var filtroreverse = empleados.Where(x => x.Edad < 40).Reverse();
//ImprimirEmpleados(filtroreverse);

////TakeWhile
//var filtro = empleados.TakeWhile(x => x.Edad < 40);
//ImprimirEmpleados(filtro);

//var grp = empleados
//    .OrderBy(e => e.Nombre)
//    .GroupBy(e => e.Departamento);
//Console.WriteLine(grp);

#endregion

#region metodos imprimir
static void ImprimirEmpleado(Empleado e)
{
    string fila = string.Format("{0,-40} {1,-10} {2, -20} {3, -15} {4}", e.Id, e.Nombre, e.Apellido, e.Departamento, e.Edad);
    Console.WriteLine(fila);
}

static void ImprimirEmpleados(IEnumerable<Empleado> lista, string titulo = "/** --- **/")
{
    Console.WriteLine(titulo);
    var encabezado = string.Format("{0,-40} {1,-10} {2, -20} {3, -15} {4}",
        "Id", "Nombre", "Apellido", "Departamento", "Edad");
    Console.WriteLine(encabezado);
    foreach (var emp in lista)
    {
        ImprimirEmpleado(emp);
    }
}
#endregion