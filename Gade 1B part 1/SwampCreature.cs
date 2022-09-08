using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    class SwampCreature : Enemy
    {
        Random rand = new Random();
        public SwampCreature(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character)
        {
            hp = 10;
            damage = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            int generateDirection = rand.Next(1, 6);

            while (/* chosen direction != empty*/)
            {
                generateDirection = rand.Next(1, 6);
            }
            return (MovementEnum)generateDirection;
        }
        
    }
}
