using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class PerroGrande : InterfazPerro
    {
        public int Alto { get; set; }
        public int Peso { get; set; }
        public int Edad { get; set; }

        public void Ladrar()
        {
            Console.WriteLine("El perro grande está ladrando.");
        }

        public void Correr()
        {
            Console.WriteLine("El perro grande está corriendo.");
        }

        public void Trepar()
        {
            Console.WriteLine("El perro grande está trepando.");
        }
    }
}

