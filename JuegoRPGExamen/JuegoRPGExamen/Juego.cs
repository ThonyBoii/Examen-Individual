using JuegoRPGExamen.Objetos;
using JuegoRPGExamen.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRPGExamen
{
    internal class Juego
    {
        private Personaje soldado1;
        private Enemigo nazi;

        public Juego()
        {
            // Inicio personaje y arma
            Arma pistola = new Arma("Pistola", 10);
            soldado1 = new Personaje("Soldado1", 100, 50, 20, pistola);
        }

        public void Iniciar()
        {
            // Comienzo del juego
            Console.WriteLine("Información del jugador:");
            soldado1.MostrarInfo();
            Console.WriteLine("\nPresiona ENTER para comenzar...");
            Console.ReadLine();

            // Zona 0
            Console.WriteLine("Te encuentras en la Zona 0. Aquí no hay enemigos.");
            Console.WriteLine("Presiona ENTER para avanzar a la Zona 1...");
            Console.ReadLine();

            // Zona 1 - Enemigo aparece
            Console.WriteLine("Has llegado a la Zona 1. ¡Aparece un Nazi!");
            nazi = new Enemigo("Nazi", 30, 5, 10);
            nazi.MostrarInfoE();

           
        }
    }
}
