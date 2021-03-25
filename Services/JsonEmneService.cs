using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using geometrifessor.Models;
using Microsoft.AspNetCore.Hosting;

namespace geometrifessor.Services
{
    public class JsonEmneService
    {
        public JsonEmneService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Emner.json"); }
        }

        public IEnumerable<Emner> GetEmner()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Emner[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}