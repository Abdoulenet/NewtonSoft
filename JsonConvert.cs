using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoft
{
    class JsonConvert<T>
    {
        JsonSerializer serializer = new JsonSerializer();

        public object DeserializeObject(string param)
        {
            return JsonConvert.DeserializeObject(param);
        }

        public object Deserialize(JsonReader param)
        {
            return serializer.Deserialize(param);
        }
    }
}
