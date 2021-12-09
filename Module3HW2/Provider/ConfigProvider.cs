using Module3HW2.Model;
using Module3HW2.Provider.Abstract;
using Module3HW2.Service.Abstract;

namespace Module3HW2.Provider
{
    public class ConfigProvider : IConfigProvider
    {
        private const string _path = "./config.json";
        private readonly IFileService _fileService;
        private readonly IJsonService _jsonService;

        public ConfigProvider(IFileService fileService, IJsonService jsonService)
        {
            _fileService = fileService;
            _jsonService = jsonService;
        }

        public Config GetConfig()
        {
            return _jsonService.Deserialization(_fileService.Read(_path), typeof(Config)) as Config;
        }
    }
}
