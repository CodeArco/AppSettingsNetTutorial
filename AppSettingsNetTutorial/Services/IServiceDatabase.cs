using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSettingsNetTutorial.Services
{
    public interface IServiceDatabase
    {
        public bool SaveData(string data);
    }
}
