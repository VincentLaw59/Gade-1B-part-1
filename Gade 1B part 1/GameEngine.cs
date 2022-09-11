using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class GameEngine
    {

        private static Map map;

        private static Hero Hero = new Hero(5, 5, 20, 20, 2, HeroChar); //fix char
        private static char heroChar = (char)208;
        private static char empty = (char)44;
        private static char swampCreature = (char)199;
        private static char obstacle = (char)42;

        public static Map Map { get { return map; } set { map = value; } }
        public static char HeroChar { get { return heroChar; }}
        public char Empty { get { return empty; }}
        public char SwampCreature { get { return swampCreature; }}
        public char Obstacle { get { return obstacle; }}

        public GameEngine()
        {
            Map = new Map(2, 8, 2, 8, 3);

            static bool MovePlayer(Character.MovementEnum direction)
            {
                    

                if ((direction == Character.MovementEnum.Up) && (Map.Player.vision[0] is EmptyTile)) 
                {
                     Map.Player.Move(direction);
                }

                if ((direction == Character.MovementEnum.Down) && (Map.Player.vision[1] is EmptyTile))
                {
                    Map.Player.Move(direction);
                }

                if ((direction == Character.MovementEnum.Left) && (Map.Player.vision[2] is EmptyTile))
                {
                    Map.Player.Move(direction);
                }

                if ((direction == Character.MovementEnum.Right) && (Map.Player.vision[3] is EmptyTile))
                {
                    Map.Player.Move(direction);
                }

                else if ((direction == Character.MovementEnum.NoMovement) && (Map.Player.vision[4] is not EmptyTile))
                {
                    Map.Player.Move(direction);
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




    

