using System;
using Module3HW2.Model;
using Module3HW2.Collection;
using Module3HW2.Service.Abstract;

namespace Module3HW2.Helper
{
    public class Application
    {
        private readonly IConfigService _configService;
        public Application(IConfigService configService)
        {
            _configService = configService;
        }

        public void Run()
        {
            var list = new ContactList();
            list.SetCulture(_configService.GetConfig().CultureConfig.Culture);
            list.Add(new Contact { FirstName = "1", SecondName = "1", PhoneNumber = "+99015648465" });
            list.Add(new Contact { FirstName = "2", SecondName = "2", PhoneNumber = "+99015648465" });
            list.Add(new Contact { FirstName = "Vadim", SecondName = "Bilyi", PhoneNumber = "+38015648465" });
            list.Add(new Contact { FirstName = "Вадик", SecondName = "Билый", PhoneNumber = "+86015648465" });
            list.Add(new Contact { FirstName = "3", SecondName = "3", PhoneNumber = "+99015648465" });
            list.SetCulture("en-EN");
            foreach (var item in list.GetSection("#"))
            {
                Console.WriteLine($"Name: {item.FullName}{Environment.NewLine}Phone number: {item.PhoneNumber}");
            }
        }
    }
}
