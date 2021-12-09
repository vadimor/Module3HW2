using System;

namespace Module3HW2.Service.Abstract
{
    public interface IJsonService
    {
        public object Deserialization(string path, Type type);
    }
}
