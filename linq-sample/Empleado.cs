using System;
using System.Collections.Generic;
using System.Text;

public enum Departamento
{
	RH = 201,
	Desarrollo = 520,
	Soporte = 402,
	Admin = 309
}

public class Empleado
{
	public Empleado()
	{

	}

	public Guid Id { get; } = Guid.NewGuid();
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public Departamento Departamento { get; set; }
    public int Edad { get; set; }
    public List<Pago> Pagos { get; set; }

}

public class Pago
{
    public int PagoId { get; set; }
    public string? Descripcion { get; set; }
    public DateTime Fecha { get; set; }
    public bool Procesado { get; set; }
    public int IdExternoEmpleado { get; set; }
}