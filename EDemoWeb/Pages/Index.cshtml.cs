﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
           // throw new Exception("Errore gravissimo!");
        }
    }
}
