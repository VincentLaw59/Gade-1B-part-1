using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    internal abstract class Tile
    {
        protected int x;
        protected int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        
       

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapons,
        }

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
