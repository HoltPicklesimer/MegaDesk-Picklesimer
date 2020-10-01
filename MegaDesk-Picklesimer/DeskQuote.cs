using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Picklesimer
{
    public enum ShippingOption
    {
        RushOrder3Day,
        RushOrder5Day,
        RushOrder7Day,
        Normal14Day
    }

    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public ShippingOption ShippingOption { get; set; }
        public decimal PriceQuote { get; set; }

        public double CalculatePriceQuote()
        {
            // Surface Area Cost
            var surfaceArea = Desk.Width * Desk.Depth;
            var surfaceAreaCost = surfaceArea > 1000 ? surfaceArea : 0;

            // Drawer Cost
            var drawerCost = Desk.Drawers * 50;

            // Material Cost
            var materialCost = 100;
            switch(Desk.SurfaceMaterial)
            {
                default:
                case DesktopMaterial.Laminate:
                    materialCost = 100;
                    break;
                case DesktopMaterial.Oak:
                    materialCost = 200;
                    break;
                case DesktopMaterial.Rosewood:
                    materialCost = 300;
                    break;
                case DesktopMaterial.Veneer:
                    materialCost = 125;
                    break;
                case DesktopMaterial.Pine:
                    materialCost = 50;
                    break;
            }

            // Shipping Cost
            double shippingCost = 0;
            if (ShippingOption != ShippingOption.Normal14Day)
            {
                if (surfaceArea < 1000)
                    shippingCost = 60;
                else if (surfaceArea <= 2000)
                    shippingCost = 70;
                else
                    shippingCost = 80;
            }

            switch (ShippingOption)
            {
                default:
                case ShippingOption.Normal14Day:
                case ShippingOption.RushOrder3Day:
                    break;
                case ShippingOption.RushOrder5Day:
                    shippingCost -= 20;
                    break;
                case ShippingOption.RushOrder7Day:
                    shippingCost /= 2.0;
                    break;
            }

            // Calculate the desk price
            PriceQuote = 200 + surfaceAreaCost + drawerCost + materialCost + shippingCost;
            return PriceQuote;
        }
    }
}
