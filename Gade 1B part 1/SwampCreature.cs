using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character)
        {
            HP = 10;
            damage = 1;
        }


    }
}
