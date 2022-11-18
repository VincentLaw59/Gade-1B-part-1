using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_POE
{
    internal class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, char character = 'S', int damage = 1, int startHP = 10) : base(x, y, character, damage, startHP)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum direction = MovementEnum.NoMovement)
        {
            MovementEnum move;
            do
            {
                move = (MovementEnum)random.Next(0, 5);
            }
            while ((vision[(int)move] is Obstacle) || (vision[(int)move] is Hero));

            return move;
        }
    }
}
