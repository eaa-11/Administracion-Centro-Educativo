using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Tarea3_Ptype
{
    abstract class ClonablePrototype<T>
    {
        public T ShallowCopy()
        {
            return (T)MemberwiseClone();
        }

        public T DeepCopy()
        {
            string result = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<T>(result);
        }
    }
}
