using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Tarea3_Ptype
{
    class DatosSerializados
    {
        public static void JsonSerializePersonas(List<IPersona> listpersonas)
        {
            string data = JsonSerializer.Serialize(listpersonas);

            using (StreamWriter sw = new StreamWriter("Alumnos.json"))
            {
                sw.Write(data);
            }
        }
    }
}
