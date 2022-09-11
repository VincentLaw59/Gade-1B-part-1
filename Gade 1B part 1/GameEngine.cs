using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class GameEngine
    {
        private Map map;
       
        private static Hero Hero = new Hero(5, 5, 20, 20, 2, HeroChar); //fix char
        private static char heroChar = (char)208;
        private static char empty = (char)44;
        private static char swampCreature = (char)199;
        private static char obstacle = (char)42;

        public Map Map { get { return map; } set { map = value; } }
        public static char HeroChar { get { return heroChar; }}
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
                    Hero!.X = Hero.X + 1;


                    return true;
                }

                if (direction == Character.MovementEnum.Down)
                {
                    Hero!.X = Hero.X - 1;

                    return true;
                }

                if (direction == Character.MovementEnum.Left)
                {
                    Hero!.Y = Hero.Y - 1;   

                    return true;
                }

                if (direction == Character.MovementEnum.Right)
                {
                    Hero!.X = Hero.X + 1;

                    return true;
                }

                else if (direction == Character.MovementEnum.NoMovement)
                {
                    Hero!.X = Hero.X + 0;
                    Hero!.X = Hero.X - 0;
                    Hero!.Y = Hero.Y + 0;
                    Hero!.Y = Hero.Y - 0;

                    return false;
                }
                return false;

            }
        }

          public override string ToString()
          {

            

            return base.ToString()!;
          }



           
           
            

    }


}




    

