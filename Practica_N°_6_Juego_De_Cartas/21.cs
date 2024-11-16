using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_N__6_Juego_De_Cartas
{
    public class _21 : JuegoDeCartas
    {
        private Random random = new Random();
        private List<int> mazo;

        public _21(Persona jugador1, Persona jugador2) : base(jugador1, jugador2)
        {
        }

        public override void MezclarElMazo()
        {
            Console.WriteLine("Empizamos!!! \n");
            Console.WriteLine("Mezclamos el mazo \n");

            mazo = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mazo.Add(i);
                }
            }

            for (int i = 0; i < mazo.Count; i++)
            {
                int j = random.Next(i, mazo.Count);
                (mazo[i], mazo[j]) = (mazo[j], mazo[i]);
            }
        }


        public override void RepartirLasCartasIniciales()
        {
            Console.WriteLine("Se repartirán las cartas iniciales para iniciar el juego...");
        }

        public override void JugarUnaMano()
        {
            Console.WriteLine("\n--- Comenzando las rondas ---");

            while (mazo.Count >= 4)
            {

                int puntosJugador1 = mazo[0] + mazo[1];
                int puntosJugador2 = mazo[2] + mazo[3];

                Console.WriteLine($"{nombre1.GetNombre()}: {mazo[0]} + {mazo[1]} = {puntosJugador1}");
                Console.WriteLine($"{nombre2.GetNombre()}: {mazo[2]} + {mazo[3]} = {puntosJugador2}");


                int diferenciaJugador1 = Math.Abs(21 - puntosJugador1);
                int diferenciaJugador2 = Math.Abs(21 - puntosJugador2);

                if (diferenciaJugador1 < diferenciaJugador2)
                {
                    Console.WriteLine($"{nombre1.GetNombre()} gana esta ronda!\n");
                    jugador1++;
                }
                else if (diferenciaJugador2 < diferenciaJugador1)
                {
                    Console.WriteLine($"{nombre2.GetNombre()} gana esta ronda!\n");
                    jugador2++;
                }
                else
                {
                    Console.WriteLine("Empate en esta ronda.\n");
                }

                mazo.RemoveRange(0, 4);

                if (jugador1 >= 5)
                {
                    Console.WriteLine($"{nombre1.GetNombre()} ha alcanzado 5 puntos y gana automáticamente el juego!");
                    break; 
                }
                else if (jugador2 >= 5)
                {
                    Console.WriteLine($"{nombre2.GetNombre()} ha alcanzado 5 puntos y gana automáticamente el juego!");
                    break;
                }
            }

        }
    }
}
