using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            double[,] data = GetRushOrder();
            int row;
            int col;
            int surfaceArea = Desk.surfaceArea();
            if(surfaceArea < 1000)
            {
                col = 0;
            
            }
            else if(surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                col = 1;
            }
            else
            {
                col = 2;
            }

            switch (rushDays){
                case 3:
                    row = 0;
                    break;
                case 5:
                    row = 1;
                    break;
                case 7:
                    row = 2;
                    break;
                default:
                    return 0;
            }
            return data[row, col];
        }

        public double calculateQuote()
        {
            // Set total to base price
            double total = BASE_PRICE;

            // Add the drawer costs to total
            total += Desk.Drawers * PRICE_PER_DRAWER;

            if (Desk.surfaceArea() > 1000) //if area is greater than 1000, we add to the base price
            {
                total += Desk.surfaceArea() * 1; //$1 per square inch
            }

            // surface material
            total += getMaterialCost(Desk.SurfaceMaterial);

            // rush order
            total += getRushCost(rushDays);

            return total;
        }

        // handle the population of a member variable that holds a 2D array that encases the logic in a trycatch block
        public double[,] GetRushOrder()
        {
            string path = @"rushOrderPrices.txt";
            try
            {
                string[] singleDimension = File.ReadAllLines(path); // Read values into single dimension array
                double[,] twoDimension = new double[3, 3]; // Use nested loops to populate 2D array (3 rows, 3 columns)
                int count = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        twoDimension[i, j] = double.Parse(singleDimension[count]); // Converts string to double
                        count++;
                    }
                }
                return twoDimension;
            }
            catch
            {
               // Creates rushOrderPrices file if it doesn't exist.
                string[] writeText = { "60", "70", "80", "40", "50", "60", "30", "35", "40" };
                File.WriteAllLines(path, writeText);
                return GetRushOrder(); //Calls itself to create the 2D array
            }
        }
    }
}