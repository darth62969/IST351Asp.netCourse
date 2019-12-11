using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstRazorPage.Pages
{
    public class Index1Model : PageModel
    {
        public String Message { get; private set; } = "Page Model in C#";

        public void OnGet()
        {
            Message += $" Server time is now { DateTime.Now}";
        }
    }
}