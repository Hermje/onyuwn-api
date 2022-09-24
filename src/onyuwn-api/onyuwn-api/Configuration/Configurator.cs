using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onyuwn_api.Configuration
{
    public class Configurator
    {
        public bool Authorize(HttpRequest req)
        {
            string attempt = req.Headers.First(x => x.Key == "APIKey").Value;
            Console.WriteLine($"API KEY: {attempt}");
            return onyuwn_api.Settings.Settings.ApiKey == attempt;
        }
    }
}
