using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Picklesimer
{
    public enum DesktopMaterials
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterials SurfaceMaterial { get; set; }
        public const decimal MIN_WIDTH = 24;
        public const decimal MAX_WIDTH = 96;
        public const decimal MIN_DEPTH = 12;
        public const decimal MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;
    }
}
