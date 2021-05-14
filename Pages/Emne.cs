using geometrifessor.Services;
using geometrifessor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace geometrifessor.Pages
{
    public class EmneModel : PageModel
    {
        private readonly ILogger<EmneModel> _logger;
        public JsonEmneService EmneService; // Her defineres funktionen EmneService med udganspunkt i JsonEmneService
        public IEnumerable<Emner> Emne { get; private set; } // Her defineres Emne

        public EmneModel(ILogger<EmneModel> logger, JsonEmneService emneService)
        {
            _logger = logger;
            EmneService = emneService;
        }

        public void OnGet()
        {
            Emne = EmneService.GetEmner(); // Her kaldes funktionen EmneService hvor man får alle emnerne
        }
    }
}
