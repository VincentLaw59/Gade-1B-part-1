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
        public Hero Player;

        private Enemy[] enemies;

        private int mapWidth;
        private int mapHeight;
        private Random rand = new Random();

        public int MapWidth { get { return mapWidth; } set { mapWidth = value; } }
        public int MapHeight { get { return mapHeight; } set { mapHeight = value; } }
        public Tile[,] gameMap { get { return map; } set { map = value; } }
        public Enemy[] Enemies { get { return enemies; } set { enemies = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int amtEnemies)
        {
            mapWidth = rand.Next(minWidth, maxWidth);
            mapHeight = rand.Next(minHeight, maxHeight);

            map = new Tile[mapWidth, mapHeight];
            enemies = new Enemy[amtEnemies];

            //Spawn Border and fill Empty Tiles
            for (int k = 0; k < mapWidth; k++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if ((k == 0) || (j == 0) || (j == mapHeight - 1) || (k == mapWidth - 1))
                    {
                        map[k, j] = new Obstacle(k, j);
                    }
                    else map[k, j] = new EmptyTile(k, j);
                }
            }

            //Spawn Hero
            Player = (Hero)Create(Tile.TileType.Hero);
            map[Player.X, Player.Y] = Player;

            //Spawn enemies
            for (int p = 0; p < enemies.Length; p++)
            {
                enemies[p] = (SwampCreature)Create(Tile.TileType.Enemy);
                enemies[p].HP = 10;
                map[enemies[p].X, enemies[p].Y] = enemies[p];
            }

            UpdateVision();
        }

        public void UpdateVision()
        {
            Player.vision[(int)Character.VisionEnum.North] = map[Player.X, Player.Y - 1];      
            Player.vision[(int)Character.VisionEnum.South] = map[Player.X, Player.Y + 1];
            Player.vision[(int)Character.VisionEnum.West] = map[Player.X - 1, Player.Y];
            Player.vision[(int)Character.VisionEnum.East] = map[Player.X + 1, Player.Y];
            
            for (int m = 0; m < enemies.Length; m++)
            {
                enemies[m].vision[(int)Character.VisionEnum.North] = map[enemies[m].X, enemies[m].Y - 1];
                enemies[m].vision[(int)Character.VisionEnum.South] = map[enemies[m].X, enemies[m].Y + 1];
                enemies[m].vision[(int)Character.VisionEnum.West] = map[enemies[m].X - 1, enemies[m].Y];
                enemies[m].vision[(int)Character.VisionEnum.East] = map[enemies[m].X + 1, enemies[m].Y];
                
            }            
        }

        private Tile DeleteThisCreate(Tile.TileType type)
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
                for (int k = 0; k < Enemies.Length; k++)
                {
                    Enemies[k] = new SwampCreature(xCoord, yCoord, 10, 10, 1, (char)190);
                }
            }
            
            //This is just to test, this is incorrect
            return Player;
        }

        private Tile Create(Tile.TileType type)
        {
            //Generate position for object
            int xCoord, yCoord;
            do
            {
                xCoord = rand.Next(1, mapWidth - 2);
                yCoord = rand.Next(1, mapHeight - 2);
            }
            while (map[xCoord, yCoord] is not EmptyTile);

            //Create Entity
            if (type == Tile.TileType.Hero) 
                return new Hero(xCoord, yCoord, 10, 10, 2, (char)208);
            else if (type == Tile.TileType.Enemy)
            {
                SwampCreature sc = new SwampCreature(xCoord, yCoord, 10, 10, 2, (char)190);
                FillEnemyArray(sc);
                return sc;
            }
            else return new EmptyTile(xCoord, yCoord);
            
        }

        private void FillEnemyArray(Enemy e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] is null)
                {
                    enemies[i] = e;
                    return;
                }
            }
        }
    }
}
