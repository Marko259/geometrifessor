using geometrifessor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geometrifessor.Pages
{
    public class ViewModel : PageModel
    {
        private readonly ILogger<ViewModel> _logger;

        public ViewModel(ILogger<ViewModel> logger JsonEmneService enmneService)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
