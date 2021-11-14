using AspNetCore6Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MyService
    {
        private readonly MySettings _settings;

        public MyService(MySettings settings)
        {
            _settings = settings;
        }

        public string Run()
        {
            return _settings.Host;
        }
    }
}
