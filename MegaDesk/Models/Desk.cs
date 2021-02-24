using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }

        //Constructor
        public Desk(int deskWidth, int deskDepth, int numDrawers, DesktopMaterial surfaceMaterial)
        {
            Width = deskWidth;
            Depth = deskDepth;
            Drawers = numDrawers;
            this.SurfaceMaterial = surfaceMaterial;
        }

        public int surfaceArea()
        {
            int Area = Width * Depth;
            return Area;
        }
    }
}