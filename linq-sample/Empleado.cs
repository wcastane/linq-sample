using System;

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

	public Guid Id { get; } = new Guid();
	public string Nombre { get; set; }
	public string Apellido { get; set; }
	public Departamento Departamento { get; set; }

}
