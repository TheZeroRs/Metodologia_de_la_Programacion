using Practica_N__6_Juego_De_Cartas;

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Juan");
        Persona persona2 = new Persona("Rodrigo");

        JuegoDeCartas Truco = new Truco(persona1, persona2); 

        Truco.Jugar();

        JuegoDeCartas veintiuno = new _21(persona1, persona2);

        veintiuno.Jugar();
        
    }
}