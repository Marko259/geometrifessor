using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace geometrifessor.Models
{
    public class Emner // Her defineres klassen 'Emner'
    {
        public string Id { get; set; } // Her fåes string Id fra vores emner.json fil
        [JsonPropertyName("img")] // her omformateres emner.json img tag til at blive kaldt når stringen 'Image' kaldes.
        public string Image { get; set; } // her defineres string Image
        public string Title { get; set; } // Her kalder vi titel tag fra emner.json
        public string shortDescription { get; set; } // Her kalder vi shortDescription tag fra emner.json
        public string Description { get; set; } // Her kalder vi Description tag fra emner.json
        public override string ToString() => JsonSerializer.Serialize<Emner>(this); // her konverteres alle vores strings til en string, hvis man kalder klassen 'Emner' får man alt vores data fra emner.json
    }
}
