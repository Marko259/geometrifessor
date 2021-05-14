using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using geometrifessor.Models;
using Microsoft.AspNetCore.Hosting;

namespace geometrifessor.Services
{
    public class JsonEmneService // her laves JsonEmneService som en klasse
    {
        public JsonEmneService(IWebHostEnvironment webHostEnvironment) // JsonEmneService labes til en service
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName 
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "emner.json"); } // her vælges filen som servicen skal kigge i for at finde den data den skal bruge
        }

        public IEnumerable<Emner> GetEmner() // her defineres funktionen hvor den får alle emnerne
        {
            using (var jsonFileReader = File.OpenText(JsonFileName)) // her laves funktionen hvor servicen skal åbne filen som text
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