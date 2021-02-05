using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Carlson
{
    public enum DesktopMaterials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
    
    public class DeskQuote
    {
        const double BASE_PRICE = 200;
        const double PRICE_PER_DRAWER = 50;
        
       //Constructor
        private string customerName;
        public string CustomerName{
            get { return customerName; } //get method
        }

        private int rushDays;
        public int RushDays
        {
            get { return rushDays; }
        }

        private Desk Desk;
        private DateTime quoteDate;
        public DateTime QuoteDate
        {
            get { return quoteDate; }
        }

        public DeskQuote(Desk newDesk, string customerName, int rushDays, DateTime quoteDate)
        {
            //to do
            this.customerName = customerName;
            this.Desk = newDesk;
            this.rushDays = rushDays;
            this.quoteDate = quoteDate;
        }

        public int getDeskWidth()
        {
            return Desk.Width;
        }

        public int getDeskDepth()
        {
            return Desk.Depth;
        }

        public int getDeskDrawers()
        {
            return Desk.Drawers;
        }

        public string getDeskMaterial()
        {
            return Desk.SurfaceMaterial.ToString();
        }
        
        public static List<DesktopMaterials> materials =
            Enum.GetValues(typeof(DesktopMaterials)).Cast<DesktopMaterials>().ToList();
        
        private int getMaterialCost(DesktopMaterial surfaceMaterial)
       {
           int cost;

           switch (surfaceMaterial)
            {
                case DesktopMaterial.Oak:
                    cost = (int) DesktopMaterials.Oak;
                    break;
                case DesktopMaterial.Laminate:
                    cost = (int) DesktopMaterials.Laminate;
                    break;
                case DesktopMaterial.Pine:
                    cost = (int) DesktopMaterials.Pine;
                    break;
                case DesktopMaterial.Rosewood:
                    cost = (int)DesktopMaterials.Rosewood;
                    break;
                case DesktopMaterial.Veneer:
                    cost = (int) DesktopMaterials.Veneer;
                    break; 
                default:
                    cost = 0;
                    break;
            }

            return cost;
       }
  
        private double getRushCost(int rushDays)
        {
            if (Desk.surfaceArea() < 1000)
            {
                switch (rushDays){
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
            else if (Desk.surfaceArea() > 1000 && Desk.surfaceArea() < 2000)
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


        public double calculateQuote()
        {
            //Set total to base price
            double total = BASE_PRICE;

            //Add the drawer costs to total
            total += Desk.Drawers * PRICE_PER_DRAWER;

            if (Desk.surfaceArea() > 1000) //if area is greater than 1000, we add to the base price
            {
                total += Desk.surfaceArea() * 1; //$1 per square inch
            }

            //surface material
            total += getMaterialCost(Desk.SurfaceMaterial);

            //rush order
            total += getRushCost(rushDays);

            return total;
        }

       }
}