using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Sample.Pages
{
    public class ValModel : PageModel
    {

        public string Message;

        [BindProperty]
        [Display (Name="Number One")]
        public int Number1 { get; set; }

        [BindProperty]
        [Required]
        [Display(Name = "Number Two")]
        public int? Number2 { get; set; }

        [BindProperty]
        [Required, MinLength(8), MaxLength(8)]
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [BindProperty]
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [BindProperty]
        [Required]
        [Compare(nameof(PhoneNumber))]
        [Display(Name = "Repeat your Phone Number")]
        public string PhoneNumber2 { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "All good!";
                
            }
            else

            { 
            Message = "Opps are you hacking!";
            }
        }
    }
}