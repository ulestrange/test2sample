using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace people.Pages
{

    //public enum Provinces
    //{
    //    Connaught,
    //    Leinster,
    //    Munster,
    //    Ulster
    //}
    public class taghelpplayModel : PageModel
    {

        public string Message = "";

        public string[] CountyList = 
            { "Sligo", "Leitrim", "Roscommon", "Galway" };

        [BindProperty]

        public bool[] CountiesSelected { get; set; }  = 
            { false, false, false, false };

        [BindProperty]

        public List<string> Province { get; set; } = new List<string> { };

        public List<SelectListItem> Provinces { get; }
            = new List<SelectListItem>
            { new SelectListItem {Value ="Connaught", Text="Connaught" },
                new SelectListItem {Value ="Leinster", Text="Leinster" },
                new SelectListItem {Value ="Munster", Text="Munster" },
                new SelectListItem {Value ="Ulster", Text="Ulster" },
                new SelectListItem {Value ="Mayo", Text="Mayo" }
            };


        [BindProperty]

        public string Colour { get; set; }



        // public SelectList SeasonList = new SelectList()

       [BindProperty]
       [Display(Name = "Numero Uno")]
        public int Number1 { get; set; }

        //  [BindProperty]
        public int Number2 { get; set; }

        //  [BindProperty]
        public double Number3 { get; set; }

        //  [BindProperty]
        public double? Number4 { get; set; }
        //  [BindProperty]
        public float Number5 { get; set; }

        //  [BindProperty]
        public float? Number6 { get; set; }
        //  [BindProperty]
        public decimal Number7 { get; set; }

        [BindProperty]
        public decimal? Number8 { get; set; }

        [BindProperty]
        //[DataType(DataType.Date)]
        [Display]

        public DateTime DateTime1 { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime DateTime2 { get; set; }

        [BindProperty]

        public DateTime? DateTime3 { get; set; }
        [BindProperty]

        public DateTime? DateTime4 { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [DataType(DataType.PhoneNumber)]
    
        public string PhoneNumber { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}