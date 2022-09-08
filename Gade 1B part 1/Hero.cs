using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Hero : Character
    {

        public Hero(int x, int y, int hp, int maxHp, int damage, char character): base(x, y, character) 
        {
            damage = 2;

        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            if(MovementEnum.Up.ToString() == characterVision[1])
            {
                //Move up
                return MovementEnum.Up;
            }

            if(MovementEnum.Down.ToString() == characterVision[2])
            {
                //Move down
                return MovementEnum.Down;
            }

            if(MovementEnum.Left.ToString() == characterVision[3])
            {
                //Move left
                return MovementEnum.Left;
            }

            if(MovementEnum.Right.ToString() == characterVision[4])
            {
                //Move right
                return MovementEnum.Right;
            }

            else
            {
                move = 0; //No movement
                return MovementEnum.NoMovement;
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string hp = "";
            string maxHp = "";
            string damage = "2";
            string x = "";
            string y = "";
                                 

            throw new NotImplementedException();
        }

       
        
    }
}
