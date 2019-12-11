using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstRazorPage.Pages
{
    public class Index2Model : PageModel
    {
        public String Message { get; private set; } = "The time is now: ";
        public void OnGet()
        {
            Message += $"{DateTime.Now}";
        }
    }
}