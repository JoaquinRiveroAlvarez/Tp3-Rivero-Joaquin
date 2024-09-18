using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Enemigo
    {
        public string nombre {  get; set; }
        public string tipoEnemigo {  get; set; }
        public int vidaEnemigo {  get; set; }
        public int danoEnemigo {  get; set; }


        public Enemigo(string nombre, string tipoEnemigo, int vidaEnemigo, int danoEnemigo)
        {
            this.nombre = nombre;
            this.tipoEnemigo = tipoEnemigo;
            this.vidaEnemigo = vidaEnemigo;
            this.danoEnemigo = danoEnemigo;
        }
        public string mostrarInfo()
        {
            
            return $"Nombre: {nombre}\n Tipo: {tipoEnemigo}\n Vida: {vidaEnemigo}\n Daño: {danoEnemigo}";
        }
        public string Atacar( Personaje personaje)
        {
            personaje.vida -= danoEnemigo;
            return $"{nombre} infligio {danoEnemigo} de daño con su ataque a {personaje.nombre}\nTu personaje ahora tiene {personaje.vida} de vida";
        }
    }
}
