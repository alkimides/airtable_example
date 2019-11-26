using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyectos.Models;

namespace Proyectos.Pages
{
    public class airtableModel : PageModel
    {
        public string Mensaje{get;set;}

        public List<Interaction> interactions{get; set;}

        public void OnGet()
        {
            Mensaje = "getting";

           

            interactions = new List<Interaction> {

                new Interaction()
                {
                    Subject = "Cold Email to Liberty Pictures",
                    Type = "Email",
                    Contacts = "Genia Helland",
                    When = "7/7/2014 8:00am",
                    RelatedDeals = "Liberty Pictures - 1 Year Video Equipment Lease",
                    Notes = "I think it went pretty well, but I really hope she didn't notice the embarrassing typo in my email."
                },

                new Interaction()
                {
                    Subject = "Email Introduction to Wolf Searchlight Productions",
                    Type = "Email",
                    Contacts = "Tawana Muro",
                    When = "7/15/2014 5:00am",
                    RelatedDeals = "Wolf Searchlight - Video Equipment Sale",
                    Notes = "I know Tawana's sister so hopefully that can help me get my foot in the door with Wolf Searchlight Pictures."
                },

                new Interaction()
                {
                    Subject = "Initial Call with Liberty Pictures",
                    Type = "Call",
                    Contacts = "Genia Helland",
                    When = "7/16/2014 7:00am",
                    RelatedDeals = "Liberty Pictures - 1 Year Video Equipment Lease",
                    Notes = "Turns out she did notice my typo, and she commented on it in the call. Ouch..."
                }

            };
        }


    }
}