using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

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
        Id = Guid.Parse("d65031f0-fdc7-44ae-8fff-56b066dc6e94"),
        Nombre = "William",
        Apellido = "Castañeda",
        Departamento = Departamento.Desarrollo,
        Edad = 37,
        Pagos = new List<Pago>
        {
            new Pago
            {
                Descripcion = "Quincena 09",
                Fecha = new DateTime(2022,05,01),
                Monto = 20000,
                Procesado = true,
                IdExternoEmpleado = Guid.Parse("d65031f0-fdc7-44ae-8fff-56b066dc6e94")
            },
            new Pago
            {
                Descripcion = "Quincena 10",
                Fecha = new DateTime(2022,05,31),
                Monto = 21000,
                Procesado = false,
                IdExternoEmpleado = Guid.Parse("d65031f0-fdc7-44ae-8fff-56b066dc6e94")
            }
        }
    },
    new Empleado
    {
        Id = Guid.Parse("120a56e8-994a-4fa7-b093-8cea9056c0af"),
        Nombre = "Carlos",
        Apellido = "Villarreal",
        Departamento = Departamento.Desarrollo,
        Edad = 34,
        Pagos = new List<Pago>
        {
            new Pago
            {
                Descripcion = "Quincena 07",
                Fecha = new DateTime(2022,04,01),
                Monto = 22000,
                Procesado = true,
                IdExternoEmpleado = Guid.Parse("120a56e8-994a-4fa7-b093-8cea9056c0af")
            },
            new Pago
            {
                Descripcion = "Quincena 08",
                Fecha = new DateTime(2022,04,30),
                Monto = 23000,
                Procesado = false,
                IdExternoEmpleado = Guid.Parse("120a56e8-994a-4fa7-b093-8cea9056c0af")
            },
            new Pago
            {
                Descripcion = "Quincena 09",
                Fecha = new DateTime(2022,05,01),
                Monto = 22000,
                Procesado = true,
                IdExternoEmpleado = Guid.Parse("120a56e8-994a-4fa7-b093-8cea9056c0af")
            },
            new Pago
            {
                Descripcion = "Quincena 10",
                Fecha = new DateTime(2022,05,31),
                Monto = 23000,
                Procesado = false,
                IdExternoEmpleado = Guid.Parse("120a56e8-994a-4fa7-b093-8cea9056c0af")
            }
        }
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre = "David",
        Apellido = "Muñiz",
        Departamento = Departamento.Desarrollo,
        Edad = 31
    },
    new Empleado
    {
        Id = Guid.Parse("4c501b10-b26c-4f5b-a2be-3ea5d77c1ae4"),
        Nombre = "Joem",
        Apellido = "Sanchez",
        Departamento= Departamento.Soporte,
        Edad = 35,
        Pagos = new List<Pago>
        {
            new Pago
            {
                Descripcion = "Quincena 10",
                Fecha = new DateTime(2022,05,31),
                Monto = 17000,
                Procesado = true,
                IdExternoEmpleado = Guid.Parse("4c501b10-b26c-4f5b-a2be-3ea5d77c1ae4")
            }
        }
    },
    new Empleado
    {
        Id = Guid.Parse("0370e550-619f-4dcf-a50c-231b14da37f7"),
        Nombre = "Juan",
        Apellido= "Tirado",
        Departamento = Departamento.Soporte,
        Edad = 42,
        Pagos = new List<Pago>
        {
            new Pago
            {
                Descripcion = "Quincena 09",
                Fecha = new DateTime(2022,05,01),
                Monto = 18000,
                Procesado = true,
                IdExternoEmpleado = Guid.Parse("0370e550-619f-4dcf-a50c-231b14da37f7")
            },
            new Pago
            {
                Descripcion = "Quincena 10",
                Fecha = new DateTime(2022,05,31),
                Monto = 19000,
                Procesado = false,
                IdExternoEmpleado = Guid.Parse("0370e550-619f-4dcf-a50c-231b14da37f7")
            }
        }
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre="Gerardo",
        Apellido="Garza",
        Departamento = Departamento.Soporte,
        Edad = 46
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre="Adriana",
        Apellido="Martinez",
        Departamento=Departamento.Admin,
        Edad = 36
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre="Lola",
        Apellido="Rincon",
        Departamento=Departamento.Admin,
        Edad = 34
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre="Octavio",
        Apellido ="Muñiz",
        Departamento = Departamento.Admin,
        Edad = 50
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre = "Angelica",
        Apellido = "Treviño",
        Departamento = Departamento.RH,
        Edad = 49
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre = "Paloma",
        Apellido = "Picos",
        Departamento = Departamento.RH,
        Edad = 45
    },
    new Empleado
    {
        Id = Guid.NewGuid(),
        Nombre = "Estefania",
        Apellido = "Martinez",
        Departamento = Departamento.RH,
        Edad = 41
    }
};

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

#region test5

////obtener todos los pagos de los empleados del departamento de desarrollo regresa una secuencia de secuencias
//var pagos = empleados.Where(x => x.Departamento == Departamento.Desarrollo).Select(e => e.Pagos);

////obtiene todos los pagos de los empleados del departamento de desarrollo regresa un enumerable de pagos
//var pagos2 = empleados.Where(x => x.Departamento == Departamento.Desarrollo && x.Pagos != null).SelectMany(e => e.Pagos);

//var cantidadPagos = pagos2.Count();
//var promedioPagos = pagos2.Average(p => p.Monto);
//var pagoMin = pagos2.Min(p => p.Monto);

//decimal monto = 20000;
////regresa true si existe algun pago menor que 20,000
//var existePagoMenor = pagos2.Any(p => p.Monto <= monto);
////regresa true si todos los pagos son menores a 20,000
//var todosPagosMenor = pagos2.All(p => p.Monto <= monto);

//var pago = pagos2.FirstOrDefault(p => p.Monto == 22000);
//Console.WriteLine($"Pago {pago.Monto}");

//var spago = pagos2.SingleOrDefault(p => p.Monto == 20000); //22,000 marca error
//Console.WriteLine($"Pago {spago.Monto}");

//var elpago = pagos2.ElementAt(2);
//Console.WriteLine($"Pago {elpago.Monto}");

#endregion

#region test6

//var nPagos = new List<Pago>
//{
//    new Pago
//    {
//        Descripcion = "Quincena 07",
//        Fecha = new DateTime(2022,04,01),
//        Monto = 18000,
//        Procesado = true,
//        IdExternoEmpleado = Guid.Parse("d65031f0-fdc7-44ae-8fff-56b066dc6e94")
//    },
//    new Pago
//    {
//        Descripcion = "Quincena 08",
//        Fecha = new DateTime(2022,04,30),
//        Monto = 19000,
//        Procesado = false,
//        IdExternoEmpleado = Guid.Parse("d65031f0-fdc7-44ae-8fff-56b066dc6e94")
//    },
//    new Pago
//    {
//        Descripcion = "Quincena 09",
//        Fecha = new DateTime(2022,05,01),
//        Monto = 19000,
//        Procesado = false,
//        IdExternoEmpleado = Guid.Parse("4c501b10-b26c-4f5b-a2be-3ea5d77c1ae4")
//    }
//};

////join
//var empleadosPagosJoin = empleados.Join(nPagos,
//                                        emp => emp.Id,
//                                        pago => pago.IdExternoEmpleado,
//                                        (emp, pago) => new
//                                        {
//                                            emp.Nombre,
//                                            pago.Monto
//                                        });


//var empleadosPagosGroupJoin = empleados.GroupJoin(nPagos,
//                                        emp => emp.Id,
//                                        pago => pago.IdExternoEmpleado,
//                                        (emp, pago) => new
//                                        {
//                                            emp.Nombre,
//                                            pagoagregados = pago
//                                        });

//foreach (var e in empleadosPagosGroupJoin)
//{
//    if (e.pagoagregados.Count() > 0)
//        Console.WriteLine(e.Nombre);
//    foreach (var p in e.pagoagregados)
//        Console.WriteLine(p.Monto);
//}

#endregion

#region json to collection

//var archivo = Path.Combine(AppContext.BaseDirectory,"empleados.json");
//var import = ObtenerEmpleados(archivo);
//var nombre = empleados.Where(e => e.Edad <= 35)
//    .Select(e => e.Nombre).FirstOrDefault();
//Console.WriteLine(nombre);

#endregion

#region json object

//JObject obj = JObject.Parse(@"{
//              'nombre': 'William Castañeda',
//              'nivel': 'Sr',
//              'edad': 37,
//              'lenguajes': [ '.NET', 'Javascript', 'Pyton' ]
//            }");
//string nivel = (string)obj["nivel"];
//Console.WriteLine(nivel);

//IList<string> lenguajes = obj["lenguajes"].Select(l => (string)l).ToList();
//foreach (var l in lenguajes)
//{
//    Console.WriteLine(l);
//}

#endregion

#region read xml linq

//var archivo = Path.Combine(AppContext.BaseDirectory, "pagos.xml");
//var docXml = XDocument.Load(archivo);
//var pagosProcesados = docXml.Element("pagos").Elements("pago")
//    .Where(p => p.Attribute("procesado")?.Value == "true")
//    //.Where(p => p.Attribute("firmado")?.Value == "true")
//    .Select(p => p.Element("descripcion").Value);

//foreach (var p in pagosProcesados)
//{
//    Console.WriteLine(p);
//}

#endregion

#region xml to object (tupla)

var archivo = @"C:\Users\noemi\source\repos\ConsoleApp1\pagos.xml";
var docXml = XDocument.Load(archivo);

var pagos = docXml.Descendants("pago").
    Where(p => p.Attribute("procesado")?.Value == "true")
    .Select(p => new Tuple<string, bool, string, float>
        (
            p.Attribute("idEmpleado").Value,
            bool.Parse(p.Attribute("firmado").Value),
            p.Element("descripcion").Value,
            float.Parse(p.Element("montoBase").Value)
        ));

#endregion

Console.ReadLine();

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

#region metodos import
static List<Empleado> ObtenerEmpleados(string ruta)
{
    List<Empleado> listaE = new List<Empleado>();
    using (System.IO.StreamReader r = new System.IO.StreamReader(ruta))
    {
        string json = r.ReadToEnd();
        listaE = JsonConvert.DeserializeObject<List<Empleado>>(json);
    }
    return listaE;
}
#endregion