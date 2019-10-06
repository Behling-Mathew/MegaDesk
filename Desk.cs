using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Behling
{
    class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        private int drawers { get; set; }

        //public enum Material { };

        // Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }

    enum Material
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
