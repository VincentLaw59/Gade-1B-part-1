using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gade_1B_part_1
{
    public class Map
    {

        private Tile[,] map;
        Hero Player;

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

            map = new Tile[mapWidth,mapHeight];

            enemies = new Enemy[amtEnemies];
            //Spawn Hero
            Create(Tile.TileType.Hero);
            //Spawn Enemies
            Create(Tile.TileType.Enemy);
  
            UpdateVision();
        }

        public void UpdateVision()
        {
            for (int k = 0; k < MapWidth; k++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    if (map[k,j] != null)
                    {
                        
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            if (type == Tile.TileType.Hero)
            {
                //Generate position for object
                int xCoord, yCoord;
                do
                {
                    xCoord = rand.Next(1, mapWidth);
                    yCoord = rand.Next(1, mapHeight);
                }
                while (map[xCoord, yCoord] is not EmptyTile);
                
                //Create Hero
                Player = new Hero(xCoord, yCoord, 10, 10, 2, (char)208);
            }

            else if (type == Tile.TileType.Enemy)
            {
                //Generate position for object
                int xCoord, yCoord;
                do
                {
                    xCoord = rand.Next(1, mapWidth);
                    yCoord = rand.Next(1, mapHeight);
                }
                while (map[xCoord, yCoord] is not EmptyTile);

                //Spawn enemies
                for (int k = 0; k < enemies.Length; k++)
                {
                    enemies[k] = new SwampCreature(xCoord, yCoord, 10, 10, 1, (char)190);
                }
            }
            

            return ;
        }
    }
}
