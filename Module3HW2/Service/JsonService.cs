using System;
using Module3HW2.Service.Abstract;
using Newtonsoft.Json;

namespace Module3HW2.Service
{
    public class JsonService : IJsonService
    {
        public object Deserialization(string jsonObj, Type type)
        {
            return JsonConvert.DeserializeObject(jsonObj, type);
        }
    }
}
