using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDesk.Models
{
    public enum DesktopMaterials
    {
        [Display(Name = "Oak")]
        Oak = 200,
        [Display(Name = "Laminate")]
        Laminate = 100,
        [Display(Name = "Pine")]
        Pine = 50,
        [Display(Name = "Rosewood")]
        Rosewood = 300,
        [Display(Name = "Veneer")]
        Veneer = 125
    }

    public class DeskQuote
    {

        public static List<SelectListItem> NumberOfDays { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "3", Text = "3 days" },
            new SelectListItem { Value = "5", Text = "5 days" },
            new SelectListItem { Value = "7", Text = "7 days"  },
            new SelectListItem { Value = "14", Text = "14 days"  }
        };
        public int ID { get; set; } //Primary id

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }

        [Display(Name = "# Days")]
        public int RushDays { get; set; }

        public int Width { get; set; }

        public int Depth { get; set; }

        public int Drawers { get; set; }

        [Display(Name = "Desk Material")]
        public DesktopMaterials SurfaceMaterial { get; set; }
    }
}
