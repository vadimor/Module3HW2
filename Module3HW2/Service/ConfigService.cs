﻿using Module3HW2.Model;
using Module3HW2.Provider.Abstract;
using Module3HW2.Service.Abstract;

namespace Module3HW2.Service
{
    public class ConfigService : IConfigService
    {
        private readonly IConfigProvider _configProvider;
        private readonly Config _config;
        public ConfigService(IConfigProvider configProvider)
        {
            _configProvider = configProvider;
            _config = _configProvider.GetConfig();
        }

        public Config GetConfig()
        {
            return _config;
        }
    }
}
