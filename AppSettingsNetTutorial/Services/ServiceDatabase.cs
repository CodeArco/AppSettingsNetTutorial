using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettingsNetTutorial.Services
{
    public class ServiceDatabase : IServiceDatabase
    {
        private Config _config;

        public ServiceDatabase(Config config)
        {
            _config = config;
        }
        public bool SaveData(string data)
        {
            // todo logic
            Console.WriteLine($"config1 from ServiceDatabase: {_config.ExampleObjectList.FirstOrDefault()?.Header.Description}");

            return true;
        }
    }
}
