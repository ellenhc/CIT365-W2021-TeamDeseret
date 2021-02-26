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
        const double BASE_PRICE = 200;
        const double PRICE_PER_DRAWER = 50;
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

        [Display(Name = "Desk Price")]
        public double Price { get; set; }

        //Gets the cost associated with each desktop material
        private static int GetMaterialCost(DesktopMaterials surfaceMaterial)
        {
            int cost;

            switch (surfaceMaterial)
            {
                case DesktopMaterials.Oak:
                    cost = (int)DesktopMaterials.Oak;
                    break;
                case DesktopMaterials.Laminate:
                    cost = (int)DesktopMaterials.Laminate;
                    break;
                case DesktopMaterials.Pine:
                    cost = (int)DesktopMaterials.Pine;
                    break;
                case DesktopMaterials.Rosewood:
                    cost = (int)DesktopMaterials.Rosewood;
                    break;
                case DesktopMaterials.Veneer:
                    cost = (int)DesktopMaterials.Veneer;
                    break;
                default:
                    cost = 0;
                    break;
            }
            return cost;
        }

        private static double GetRushCost(int rushDays, double surfaceArea)
        {
            if (surfaceArea < 1000)
            {
                switch (rushDays)
                {
                    case 3:
                        return 60;
                    case 5:
                        return 40;
                    case 7:
                        return 30;
                    default:
                        return 0;
                }
            }
            else if (surfaceArea > 1000 && surfaceArea < 2000)
            {
                switch (rushDays)
                {
                    case 3:
                        return 70;
                    case 5:
                        return 50;
                    case 7:
                        return 35;
                    default:
                        return 0;
                }
            }
            else
            {
                switch (rushDays)
                {
                    case 3:
                        return 80;
                    case 5:
                        return 60;
                    case 7:
                        return 40;
                    default:
                        return 0;
                }
            }
        }

        public double CalculateQuote()
        {
            double total = BASE_PRICE; // Set total to base price
            total += Drawers * PRICE_PER_DRAWER; // Add the drawer costs to total
            double surfaceArea = Width * Depth;
            if (surfaceArea > 1000) //if area is greater than 1000, we add to the base price
            {
                total += surfaceArea * 1; //$1 per square inch
            }
            total += GetMaterialCost(SurfaceMaterial); //Add price of material
            total += GetRushCost(RushDays, surfaceArea); //Add price of order days
            return total;
        }
    }
}
