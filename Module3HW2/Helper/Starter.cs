using Microsoft.Extensions.DependencyInjection;
using Module3HW2.Provider;
using Module3HW2.Provider.Abstract;
using Module3HW2.Service;
using Module3HW2.Service.Abstract;

namespace Module3HW2.Helper
{
    public class Starter
    {
        public void Start()
        {
            var starter = new ServiceCollection()
                .AddTransient<IConfigProvider, ConfigProvider>()
                .AddSingleton<IConfigService, ConfigService>()
                .AddTransient<IFileService, FileService>()
                .AddTransient<IJsonService, JsonService>()
                .AddTransient<Application>()
                .BuildServiceProvider();
            var app = starter.GetService<Application>();
            app.Run();
        }
    }
}
