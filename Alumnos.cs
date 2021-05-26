using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_Ptype
{
    class Alumnos:ClonablePrototype<Alumnos>,IPersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string Grado { get; set; }
        public Padres Padre;

        public Alumnos()
        {
            Padre = new Padres();
        }

        public string Print(string message)
        {
            Console.WriteLine("\nAlumnos" + message + "\n");
            return $"-Nombre:{Nombre}" +
                $"\n-Edad:{Edad}" +
                $"\n-Nacionalidad: {Nacionalidad}" +
                $"\n-Telefono: {Telefono}" +
                $"\n-Grado: {Grado}" +
                $"\n-Nombre del Padre:{Padre.Nombre}" +
                $"\n-Telefono del Padre: {Padre.Telefono}";
        }

        public void Comer()
        {
            Console.WriteLine("Yo como");
        }

        public void Estudiar()
        {
            Console.WriteLine("Yo estudio");
        }
    }
}
