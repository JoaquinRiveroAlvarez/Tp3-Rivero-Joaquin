using System;

public class Armas
{
		public string nombre {  get; set; }
	    public string calidad { get; set; }
	    public string descripcion {  get; set; }
	    public int dano { get; set; }

	public Armas(string nombre, string calidad, string descripcion, int dano)
	{
		this.nombre = nombre;
		this.calidad = calidad;
		this.descripcion = descripcion;
		this.dano = dano;
	}

	public string mostrarArma()
	{
		
		return;
	}
}
