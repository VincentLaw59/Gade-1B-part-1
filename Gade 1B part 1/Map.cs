using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Map
    {
        private Tile[]? map;
        Hero? Hero;
        private Enemy[] enemies;

        private int mapWidth;
        private int mapHeight;
        private Random rand = new Random();

        public int MapWidth { get { return mapWidth; } set { mapWidth = value; } }
        public int MapHeight { get { return mapHeight; } set { mapHeight = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int amtEnemies)
        {
            mapWidth = rand.Next(minWidth, maxWidth);
            mapHeight = rand.Next(minHeight, maxHeight);

            enemies = new Enemy[amtEnemies];
            Create();
            
        }

        

        private void Create()
        {
            int xCoord = rand.Next(1, mapWidth);
            int yCoord = rand.Next(1, mapHeight);

            //Create Hero
            Hero = new Hero(xCoord, yCoord, 10, 10, 2, (char)208);

            //Loop through enemies creating all of them
            for (int k = 1; k < enemies.Length; k++)
            {

            }

            //Puts them in Tile map

            //UpdateVision
        }
    }
}
