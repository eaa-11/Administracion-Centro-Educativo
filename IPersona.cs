using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_Ptype
{
    interface IPersona
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string Nacionalidad { get; set; }
        string Telefono { get; set; }

        string Print(string message);
        void Comer();
    }
}
