using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    internal class Hero : Character
    {
        //public Hero(int x, int y, char character) : base(x, y, character)
        //{
        //}

        public Hero(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character) 
        {
            damage = 2;


        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void ReturnMove(Enum moveIndicator)
        {
            


        }


    }
}
