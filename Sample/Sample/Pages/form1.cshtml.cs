using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sample.Pages
{
    public class Form1Model : PageModel
    {
        [BindProperty]
        public bool HasVisitedSligo { get; set; }

        [BindProperty]
        public bool[] HasVisitedCounty { get; set; } =
            {false, false, false, false, false};

        public string[] CountyList { get; set; }
        = { "Sligo", "Leitrim", "Mayo", "Roscommon", "Galway" };

        public void OnGet()
        {

        }
    }
}