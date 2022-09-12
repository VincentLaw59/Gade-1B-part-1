﻿using System;
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

        private static Enemy[]? enemies;

        private int mapWidth;
        private int mapHeight;
        private Random rand = new Random();

        public int MapWidth { get { return mapWidth; } set { mapWidth = value; } }
        public int MapHeight { get { return mapHeight; } set { mapHeight = value; } }
        public Tile[,] gameMap { get { return map; } set { map = value; } }
        public static Enemy[] Enemies { get { return enemies!; } set { enemies = value; } }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int amtEnemies)
        {
            mapWidth = rand.Next(minWidth, maxWidth);
            mapHeight = rand.Next(minHeight, maxHeight);

            map = new Tile[mapWidth,mapHeight];

            //Spawn Border
            for (int k = 0; k < mapWidth; k++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if ((k == 0) || (j == 0) || (j == mapHeight - 1) || (k == mapWidth - 1))
                    {
                        map[k, j] = new Obstacle(k, j);
                    }
                }
            }
            enemies = new Enemy[amtEnemies];

            //Spawn Hero
            Player = (Hero)Create(Tile.TileType.Hero);
            map[Player.X, Player.Y] = Player;

            //Spawn enemies
            for (int p = 0; p < enemies.Length; p++)
            {
                enemies[p] = (Enemy)Create(Tile.TileType.Enemy);
                map[enemies[p].X, enemies[p].Y] = enemies[p];
            }

            UpdateVision();

        }

        public void UpdateVision()
        {
            for (int k = 1; k < MapWidth - 1; k++)
            {
                for (int j = 1; j < MapHeight - 1; j++)
                {
                    if (map[k,j] is Hero)
                    {
                        Player.vision[(int)Character.VisionEnum.North] = map[k + 1, j];
                        Player.vision[(int)Character.VisionEnum.South] = map[k - 1, j];
                        Player.vision[(int)Character.VisionEnum.West] = map[k, j - 1];
                        Player.vision[(int)Character.VisionEnum.East] = map[k, j + 1];

                    }
                    else if (map[k,j] is Enemy)
                    {
                        for (int m = 0; m < enemies.Length; m++)
                        {
                            enemies[m].vision[(int)Character.VisionEnum.North] = map[k + 1, j];
                            enemies[m].vision[(int)Character.VisionEnum.South] = map[k - 1, j];
                            enemies[m].vision[(int)Character.VisionEnum.West] = map[k, j + 1];
                            enemies[m].vision[(int)Character.VisionEnum.East] = map[k, j - 1];
                        }
                    }
                }
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
                xCoord = rand.Next(1, mapWidth - 1);
                yCoord = rand.Next(1, mapHeight - 1);
            }
            while (map[xCoord, yCoord] != null);

            //Create Entity
            if (type == Tile.TileType.Hero)
                return new Hero(xCoord, yCoord, 10, 10, 2, (char)208);
            else if (type == Tile.TileType.Enemy)
                return new SwampCreature(xCoord, yCoord, 10, 10, 2, (char)190);
            else return new EmptyTile(xCoord, yCoord);
        }
    }
}
