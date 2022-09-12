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
        private Tile temp;

        //private static Hero hero = new Hero(5, 5, 20, 20, 2, HeroChar); //fix char
        private static char heroChar = (char)208;
        private static char empty = (char)44;
        private static char swampCreature = (char)199;
        private static char obstacle = (char)42;

        public Map Map { get { return map; } set { map = value; } }
        public static char HeroChar { get { return heroChar; } }
        public char Empty { get { return empty; } }
        public char SwampCreature { get { return swampCreature; } }
        public char Obstacle { get { return obstacle; } }
        //public static Hero Hero { get { return hero; } set { hero = value; } }

        public GameEngine()
        {
            map = new Map(5, 10, 5, 10, 6);

        }
        public bool MovePlayer(Character.MovementEnum direction)
        {


            if ((direction == Character.MovementEnum.Up) && (map.player.vision[(int)Character.VisionEnum.West] is EmptyTile))
            {
                //Holds where the player is currently

                //Player moves to new pos
                Map.player.Move(direction);
                //Map.gameMap[temp.X, temp.Y] = new EmptyTile(temp.X, temp.Y);


                return true;
            }

            else if ((direction == Character.MovementEnum.Down) && (map.player.vision[(int)Character.VisionEnum.East] is EmptyTile))
            {
                Map.player.Move(direction);
                return true;
            }

            else if ((direction == Character.MovementEnum.Left) && (map.player.vision[(int)Character.VisionEnum.North] is EmptyTile))
            {
                Map.player.Move(direction);
                return true;
            }

            else if ((direction == Character.MovementEnum.Right) && (map.player.vision[(int)Character.VisionEnum.South] is EmptyTile))
            {
                Map.player.Move(direction);
                return true;
            }

            else if ((direction == Character.MovementEnum.NoMovement) && (map.player.vision[4] is not EmptyTile))
            {
                Map.player.Move(direction);
                return true;

            }
            else return false;

        }


        public override string ToString()
        {
            string horizontal = "";
            for (int k = 0; k < map.MapWidth; k++)
            {
                string verticalString = "";
                for (int i = 0; i < map.MapHeight; i++)
                {
                    Tile VerticalEntity = map.gameMap[k, i];

                    if (VerticalEntity == null)
                    {
                        map.gameMap[k, i] = new EmptyTile(k, i);
                    }

                    VerticalEntity = map.gameMap[k, i];

                    if (VerticalEntity is EmptyTile)
                    {
                        verticalString += "." + "\t";
                    }
                    else if (VerticalEntity is Enemy)
                    {
                        verticalString += "E" + "\t";
                    }
                    else if (VerticalEntity is Hero)
                    {
                        verticalString += "H" + "\t";
                    }
                    else if (VerticalEntity is Obstacle)
                    {
                        verticalString += "X" + "\t";
                    }
                    
                }
                horizontal = verticalString + "\n";
            }
            return horizontal;

        }

    }
}



    

