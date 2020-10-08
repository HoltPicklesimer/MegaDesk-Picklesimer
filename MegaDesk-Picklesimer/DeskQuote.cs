using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Picklesimer
{
    public enum DeliveryOption
    {
        Rush3Day,
        Rush5Day,
        Rush7Day,
        NoRush
    }

    public class DeskQuote
    {
        // Private variables
        private int[,] _rushOrderPrices;

        // Constants
        private const decimal BASE_COST = 200M;
        private const decimal LAMINATE_COST = 100M;
        private const decimal OAK_COST = 200M;
        private const decimal ROSEWOOD_COST = 300M;
        private const decimal VENEER_COST = 125M;
        private const decimal PINE_COST = 50M;
        private const decimal DRAWER_COST = 50M;
        private const decimal SURFACEAREA_COST = 200M;

        // Public variables
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public DeliveryOption ShippingOption { get; set; }
        public decimal PriceQuote { get; set; }

        public decimal CalculatePriceQuote()
        {
            // Surface Area Cost
            var surfaceArea = Desk.Width * Desk.Depth;
            var surfaceAreaCost = 0M;
            if (surfaceArea > 1000)
                surfaceAreaCost = surfaceArea * SURFACEAREA_COST - 1000;

            // Drawer Cost
            var drawerCost = Desk.Drawers * DRAWER_COST;

            // Material Cost
            var materialCost = 0M;
            switch(Desk.SurfaceMaterial)
            {
                default:
                case DesktopMaterial.Laminate:
                    materialCost = LAMINATE_COST;
                    break;
                case DesktopMaterial.Oak:
                    materialCost = OAK_COST;
                    break;
                case DesktopMaterial.Rosewood:
                    materialCost = ROSEWOOD_COST;
                    break;
                case DesktopMaterial.Veneer:
                    materialCost = VENEER_COST;
                    break;
                case DesktopMaterial.Pine:
                    materialCost = PINE_COST;
                    break;
            }

            // Shipping Cost
            decimal shippingCost = 0;
            if (ShippingOption != DeliveryOption.NoRush)
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
                case DeliveryOption.NoRush:
                case DeliveryOption.Rush3Day:
                    break;
                case DeliveryOption.Rush5Day:
                    shippingCost -= 20;
                    break;
                case DeliveryOption.Rush7Day:
                    shippingCost /= 2M;
                    break;
            }

            // Calculate the desk price
            PriceQuote = BASE_COST + surfaceAreaCost + drawerCost + materialCost + shippingCost;
            return PriceQuote;
        }
    }
}
