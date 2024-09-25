using System;
namespace Objetos
{
    public class Arma
    {
        private int vidaEnemigo;
        private int vida;

        public string nombre { get; set; }
        public string calidad { get; set; }
        public string descripcion { get; set; }
        public int dano { get; set; }

        public Arma(string nombre, string calidad, string descripcion, int dano)
        {
            this.nombre = nombre;
            this.calidad = calidad;
            this.descripcion = descripcion;
            this.dano = dano;
        }
        public string mostrarArma()
        {
            return $" Nombre: {nombre}\n Calidad: {calidad}\n Descripción: {descripcion}\n Daño: {dano}";
        }
        
        public string Atacar(Enemigo enemigo, Personaje personaje)
        {
            enemigo.vidaEnemigo -= dano;
            if(enemigo.vidaEnemigo < 0)
            {
                enemigo.vidaEnemigo = 0;
            }
            return $"{personaje.nombre} infligio {dano} de daño con su ataque a {enemigo.nombre}\n, ahora el enemigo tiene {enemigo.vidaEnemigo} de vida";
        }
    }
}
