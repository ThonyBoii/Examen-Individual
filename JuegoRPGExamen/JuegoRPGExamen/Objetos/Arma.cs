using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRPGExamen.Objetos
{
    internal class Arma
    {
        string Nombre { get; }
        int Dano { get; }

        public Arma(string nombre, int daño)
        {
            Nombre = nombre;
            Dano = daño;
        }

    }
}
