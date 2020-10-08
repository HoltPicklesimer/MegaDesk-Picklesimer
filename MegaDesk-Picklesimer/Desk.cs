using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Picklesimer
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        //TEST PUSH
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWERS = 0;
        public const int MAX_DRAWERS = 7;

        public Desk()
        {

        }
    }
}
