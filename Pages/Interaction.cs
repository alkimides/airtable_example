using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyectos.Models
{
    public class Interaction
    {
        public string Subject{get;set;}

        public string Type{get;set;}

        public string Contacts{get;set;}

        public string When{get;set;}

        public string RelatedDeals{get;set;}

        public string Notes{get;set;}

        
    }
}