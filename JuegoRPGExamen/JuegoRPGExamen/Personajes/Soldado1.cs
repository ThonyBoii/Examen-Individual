using JuegoRPGExamen.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JuegoRPGExamen.Personajes
{
    internal class Soldado1 : Personaje
    {

        public List<Item> Items { get; private set; }
        public Soldado1(string nombre, int vida, int velocidad, int defensa)
        {
            Nombre = nombre;
            Vida = vida;
            Velocidad = velocidad;
            Defensa = defensa;
            Items = new List<Item>();
        }

        public void UsaItem(Item item)
        {
            item.Usa(this);
            Items.Remove(item);
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($"Defensa: {Defensa}");
            Console.WriteLine($"Velocidad: {Velocidad}");
            Console.WriteLine($"Arma: {Arma.Nombre}");
            Console.WriteLine($"Item: {(Item != null ? Item.Nombre : "Ninguno")}");
        }

    }
}
