using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class GameEngine
    {
        private Map? map;
       
        private static char hero = (char)208;
        private static char empty = (char)44;
        private static char swampCreature = (char)199;
        private static char obstacle = (char)42;

        public Map? Map { get { return map; } set { map = value; } }
        public char Hero { get { return hero; }}
        public char Empty { get { return empty; }}
        public char SwampCreature { get { return swampCreature; }}
        public char Obstacle { get { return obstacle; }}

        public GameEngine()
        {
            Map = new Map(2, 8, 2, 8, 3);

            static bool MovePlayer(Character.MovementEnum direction)
            {
                if (direction == Character.MovementEnum.Up)
                {
                    return true;
                }

                if (direction == Character.MovementEnum.Down)
                {
                    return true;
                }

                if (direction == Character.MovementEnum.Left)
                {
                    return true;
                }

                if (direction == Character.MovementEnum.Right)
                {
                    return true;
                }

                else if (direction == Character.MovementEnum.NoMovement)
                {
                    return false;
                }
                return false;

            }
        }

          public override string ToString()
          {

            

            return base.ToString();
          }



           
           
            

    }


}




    

