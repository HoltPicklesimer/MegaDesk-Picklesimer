using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Picklesimer
{
    public enum DeliveryOptions
    {
        [Description("Rush - 3 Day")]
        Rush3Day,
        [Description("Rush - 5 Day")]
        Rush5Day,
        [Description("Rush - 7 Day")]
        Rush7Day,
        [Description("No Rush")]
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
        private const decimal SURFACEAREA_COST = 1M;

        // Public variables
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public DeliveryOptions DeliveryOption { get; set; }
        public decimal PriceQuote { get; set; }
        public DateTime QuoteDate { get; set; }

        public decimal CalculatePriceQuote()
        {
            // Get the rush order prices
            GetRushOrder();

            // Surface Area Cost
            var surfaceArea = Desk.Width * Desk.Depth;
            var surfaceAreaCost = 0M;
            if (surfaceArea > 1000)
                surfaceAreaCost = (surfaceArea - 1000) * SURFACEAREA_COST;

            // Drawer Cost
            var drawerCost = Desk.Drawers * DRAWER_COST;

            // Material Cost
            decimal materialCost;
            switch(Desk.SurfaceMaterial)
            {
                default:
                case DesktopMaterials.Laminate:
                    materialCost = LAMINATE_COST;
                    break;
                case DesktopMaterials.Oak:
                    materialCost = OAK_COST;
                    break;
                case DesktopMaterials.Rosewood:
                    materialCost = ROSEWOOD_COST;
                    break;
                case DesktopMaterials.Veneer:
                    materialCost = VENEER_COST;
                    break;
                case DesktopMaterials.Pine:
                    materialCost = PINE_COST;
                    break;
            }

            // Delivery Cost
            var deliveryCost = GetDeliveryCost(surfaceArea);

            // Calculate the desk price
            PriceQuote = BASE_COST + surfaceAreaCost + drawerCost + materialCost + deliveryCost;
            return PriceQuote;
        }

        // Read in the Rush Order Prices from rushOrderPrices.txt
        private void GetRushOrder()
        {
            try
            {
                var prices = File.ReadAllLines("rushOrderPrices.txt");
                _rushOrderPrices = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        _rushOrderPrices[i, j] = int.Parse(prices[i * 3 + j]);
                }
            }
            catch (Exception ex)
            {
                var message = string.Format("Error getting rush order prices: {0},"
                    + " Stack Trace: {1}", ex.Message, ex.StackTrace);
                MessageBox.Show(message);
            }
        }

        private decimal GetDeliveryCost(decimal surfaceArea)
        {
            var deliveryCost = 0M;

            if (DeliveryOption != DeliveryOptions.NoRush)
            {
                var deliveryIndex = 0;
                var sizeIndex = 0;
                switch (DeliveryOption)
                {
                    case DeliveryOptions.Rush3Day:
                        deliveryIndex = 0;
                        break;
                    case DeliveryOptions.Rush5Day:
                        deliveryIndex = 1;
                        break;
                    case DeliveryOptions.Rush7Day:
                        deliveryIndex = 2;
                        break;
                }

                if (surfaceArea < 1000)
                    sizeIndex = 0;
                else if (surfaceArea <= 2000)
                    sizeIndex = 1;
                else
                    sizeIndex = 2;

                deliveryCost = _rushOrderPrices[deliveryIndex, sizeIndex];
            }

            return deliveryCost;
        }
    }
}
