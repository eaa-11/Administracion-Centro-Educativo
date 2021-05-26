using System;
using System.Collections.Generic;
namespace Tarea3_Ptype
{
    class Program
    {
        public static List<IPersona> personas = new List<IPersona>();

        static void Main(string[] args)
        {
            ClonSuperficial();
            Console.ReadKey();
            ClonProfundo();
        }

        #region ClonadoSuperficial
        public static void ClonSuperficial()
        {
            Padres p = new Padres()
            {
                Nombre = "Juan",
                Edad = 54,
                Nacionalidad = "Dominicano",
                Telefono = "871283-2398284",
                Cedula = "2325384",
                Cargo = "Arquitecto",
            };

            Console.WriteLine(p.Print("\"Original\""));

            Padres p1 = p.ShallowCopy();
            p1.Nombre = "Estrella";
            p1.Edad = 23;
            p1.Nacionalidad = "Ruso";
            p1.Telefono = "193-922493";
            p1.Cedula = "83274856858357";
            p1.Cargo = "Ingeniero Civil";

            Console.WriteLine(p1.Print("\"Shallow Copy\""));

            Padres p2 = p.ShallowCopy();
            p2.Nombre = "Rose";
            p2.Edad = 32;
            p2.Nacionalidad = "Italiana";
            p2.Telefono = "1823-1291-493";
            p2.Cedula = "923484030435";
            p2.Cargo = "Psicologa";

            Console.WriteLine(p2.Print("\"Shallow Copy\""));

            Padres p3 = p.ShallowCopy();
            p3.Nombre = "Ironelis";
            p3.Edad = 54;
            p3.Nacionalidad = "Americana";
            p3.Telefono = "82483-249395";
            p3.Cedula = "9384956765";
            p3.Cargo = "Algo ahi";

            Console.WriteLine(p3.Print("\"Shallow Copy\""));

            personas.Add(p);
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            DatosSerializados.JsonSerializePersonas(personas);
        }
        #endregion

        #region Clonado Profundo
        private static void ClonProfundo()
        {
            Alumnos a = new Alumnos();
            a.Nombre = "Adrian";
            a.Edad = 24;
            a.Nacionalidad = "Dominicana";
            a.Telefono = "829-906-9805";
            a.Grado = "Universitario";
            a.Padre.Nombre= "Juan";
            a.Padre.Telefono= "83748759496";
            Console.WriteLine(a.Print("\"Original\""));

            Alumnos a1 = a.DeepCopy();
            a1.Nombre = "Rose";
            a1.Edad = 27;
            a1.Nacionalidad = "Italiana";
            a1.Telefono = "02358-2342";
            a1.Grado = "Universitario";
            a1.Padre.Nombre = "Danilo";
            a1.Padre.Telefono = "923849354";
            Console.WriteLine(a1.Print("\"Deep Copy\""));

            Alumnos a2 = a.DeepCopy();
            a2.Nombre = "Jonathan";
            a2.Edad = 35;
            a2.Nacionalidad = "Dominicano";
            a2.Telefono = "90-34883";
            a2.Grado = "2do";
            a2.Padre.Nombre = "Juan";
            a2.Padre.Telefono = "93584-2324";
            Console.WriteLine(a2.Print("\"Deep Copy\""));

            personas.Add(a);
            personas.Add(a1);
            personas.Add(a2);
            DatosSerializados.JsonSerializePersonas(personas);
        }
        #endregion
    }
}
