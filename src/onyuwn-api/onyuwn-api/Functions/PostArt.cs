using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using onyuwn_api.Configuration;

namespace onyuwn_api.Functions
{
    public static class PostArt
    {
        [FunctionName("PostArt")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            Configurator config = new Configurator();
            IActionResult result = null;
            if (config.Authorize(req))
            {
                result = new OkObjectResult("heeyy");
            }
            else
            {
                result = new BadRequestResult();
            }

            return result;
        }
    }
}
