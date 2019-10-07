using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Behling
{
    class DeskQuote : Desk
    {
        private string customerName { get; set; }
        private int rushOrder { get; set; }
        private double price { get; set; }
        private int surfaceArea { get; set; }

        public const int BASE_COST = 200;
        public const int DRAWER_PRICE = 50;





        public double calcPrice(int rushOrder, int drawers, Material material, int surfaceArea)
        {

            if (drawers > 0)
            { drawers *= DRAWER_PRICE; } // price per drawer is $50
            int total = BASE_COST + (int)material + drawers;

            if (surfaceArea > 1000)
            {
                total = BASE_COST + (int)material + drawers + rushOrder + surfaceArea - 1000; //charge $1 per inch after 1000
            }
            else total = BASE_COST + (int)material + drawers + rushOrder;
            return total;
           
        }

        public int getRushOrder(int rushOrder, int surfaceArea)
        {
            if (rushOrder == 3 && surfaceArea < 1000) return 60;
            else if (rushOrder == 3 && surfaceArea >= 1000 && surfaceArea <= 2000) return 70;
            else if (rushOrder == 3 && surfaceArea > 2000) return 80;
            else if (rushOrder == 5 && surfaceArea < 1000) return 40;
            else if (rushOrder == 5 && surfaceArea >= 1000 && surfaceArea <= 2000) return 50;
            else if (rushOrder == 5 && surfaceArea > 2000) return 60;
            else if (rushOrder == 7 && surfaceArea < 1000) return 30;
            else if (rushOrder == 7 && surfaceArea >= 1000 && surfaceArea <= 2000) return 35;
            else if (rushOrder == 7 && surfaceArea > 2000) return 40;
            else return 0;
        }
    }

   
}
