using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_Ptype
{
    class Padres:ClonablePrototype<Padres>,IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }

        public string Print(string message)
        {
            Console.WriteLine("\nPadres" + message + "\n");
            return $"-Nombre:{Nombre}" +
                $"\n-Edad:{Edad}" +
                $"\n-Nacionalidad: {Nacionalidad}" +
                $"\n-Telefono: {Telefono}" +
                $"\n-Cedula: {Cedula}" +
                $"\n-Cargo:{Cargo}";
        }

        public void Comer()
        {
            Console.WriteLine("Yo como");
        }

        public void Trabajar()
        {
            Console.WriteLine("Yo trabajo");
        }
    }
}
