using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    internal abstract class Enemy : Character
    {
        protected Enemy(int x, int y, char character) : base(x, y, character)
        {
        }

        protected int random;
        public int Random { get { return random; } set { random = value; } }
        //is this not supposed to be "Random rand = new Random()"

        public Enemy(int x, int y, int damage, char character): base(x, y, character)
        {
           
        }
          
       public override string ToString()
        {
            return $"{this.GetType().Name} at [{x}, {y}] ({damage})";
        }


    }
}
