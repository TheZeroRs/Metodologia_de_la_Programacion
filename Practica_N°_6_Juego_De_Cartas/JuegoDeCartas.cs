using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6_Juego_De_Cartas
{
    public abstract class JuegoDeCartas
    {
        protected int jugador1 = 0;
        protected int jugador2 = 0;
        protected Persona nombre1; 
        protected Persona nombre2;
        
        public JuegoDeCartas(Persona jugador1, Persona jugador2)
        {
            this.nombre1 = jugador1;
            this.nombre2 = jugador2;
        }

        public void Jugar()
        {
            MezclarElMazo();
            RepartirLasCartasIniciales();
            JugarUnaMano();
            ChequearGanador();
        }

        public abstract void MezclarElMazo();
        public abstract void RepartirLasCartasIniciales();
        public abstract void JugarUnaMano();

        public virtual void ChequearGanador()
        {
            Console.WriteLine($"\nPuntos finales: {nombre1.GetNombre()}: {jugador1}, {nombre2.GetNombre()}: {jugador2}");
            if (jugador1 > jugador2)
            {
                Console.WriteLine($"¡{nombre1.GetNombre()} es el ganador final!");
            }
            else if (jugador2 > jugador1)
            {
                Console.WriteLine($"¡{nombre2.GetNombre()} es el ganador final!");
            }
            else
            {
                Console.WriteLine("Empate!!!");
            }
        }

    }
}
