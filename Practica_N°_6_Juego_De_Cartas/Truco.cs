using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6_Juego_De_Cartas
{
    public class Truco : JuegoDeCartas
    {
        private Random random = new Random();
        private int totalManos = 3;

        public Truco(Persona jugador1, Persona jugador2) : base(jugador1, jugador2)
        {
        }

        public override void MezclarElMazo()
        {
            Console.WriteLine("Empizamos!!! \n");
            Console.WriteLine("Mezclamos el mazo \n");
        }
        public override void RepartirLasCartasIniciales()
        {
            Console.WriteLine("Se reparten 3 cartas para cada jugador \n");
        }
        public override void JugarUnaMano()
        {
            for (int i = 0; i < totalManos; i++)
            {
                Console.WriteLine($"\n--- Jugando Mano {i + 1} ---");
                jugarUnaRonda();
            }
        }

        public void jugarUnaRonda() 
        {
            Console.WriteLine($"{nombre1.GetNombre()} tira una carta \n");
            Console.WriteLine($"{nombre2.GetNombre()} tira una carta \n");

            int ganadorMano = random.Next(1, 3);

            if (ganadorMano == 1)
            {
                jugador1++;
                Console.WriteLine($"{nombre1.GetNombre()} gana esta mano!");
            }
            else
            {
                jugador2++;
                Console.WriteLine($"{nombre2.GetNombre()} gana esta mano!");
            }
        }

    }
}
