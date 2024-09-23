using JuegoRPGExamen.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRPGExamen.Personajes
{
    internal class Nazi : Enemigo
    {
        public Nazi(string nombre, int vida, int velocidad, int defensa)
        {
            NombreE = nombre;
            VidaE = vida;
            VelocidadE = velocidad;
            DefensaE = defensa;
        }

        public void MostrarInfoE()
        {
            Console.WriteLine($"Enemigo: {NombreE}");
            Console.WriteLine($"Vida: {VidaE}");
            Console.WriteLine($"Defensa: {DefensaE}");
            Console.WriteLine($"Velocidad: {VelocidadE}");
        }

    }
}
