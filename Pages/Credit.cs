using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geometrifessor.Pages
{
    public class CreditModel : PageModel // Her laves en klasse hvor der defineres hvilken form for model Index.cshtml bruger og hvad den har adgang til.
    {
        private readonly ILogger<CreditModel> _logger;

        public CreditModel(ILogger<CreditModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
