using JuegoRPGExamen.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRPGExamen.Objetos
{

    // interface define qué métodos, propiedades o eventos debe implementar una clase
    interface Item
    {
        string Nombre { get; }
        void Usa(Soldado1 soldado1);
    }
}
