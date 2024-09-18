namespace Objetos
{
    public class Personaje
    {
        public string nombre { get; set; }
        public string sexo { get; set; }
        public int vida {  get; set; }
        public string tipoPersonaje {  get; set; }
        public Arma arma { get; set; }
        public Personaje(string nombre, string sexo, int vida, string tipoPersonaje, Arma arma)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.vida = vida;
            this.tipoPersonaje = tipoPersonaje;
            this.arma = arma;
        }
        public void Curarse()
        {

        }
        public string MostrarInfoPersonaje()
        {
            return $"Nombre: {nombre}\n Sexo: {sexo}\n Vida: {vida}\n Tipo: {tipoPersonaje}";
        }
    }
}
