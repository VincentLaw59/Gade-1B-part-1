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

        private Enemy[] enemies;

        private int mapWidth;
        private int mapHeight;
        private Random rand = new Random();

        public int MapWidth { get { return mapWidth; } set { mapWidth = value; } }
        public int MapHeight { get { return mapHeight; } set { mapHeight = value; } }
        public Tile[,] gameMap { get { return map; } set { map = value; } }
    
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int amtEnemies)
        {
            mapWidth = rand.Next(minWidth, maxWidth);
            mapHeight = rand.Next(minHeight, maxHeight);

            map = new Tile[mapWidth,mapHeight];

            enemies = new Enemy[amtEnemies];
            //Spawn Hero
            Create(Tile.TileType.Hero);
            //Spawn enemies
            DeleteThisCreate(Tile.TileType.Enemy);


            for (int k = 0; k < enemies.Length; k++)
            {
                enemies[k] = (Enemy)Create(Tile.TileType.Enemy);    //Possible Error
            }

            UpdateVision();
        }

        //Q3.2/////////////not finished yet/////////////
        public void UpdateVision()
        {
            for (int k = 0; k < MapWidth; k++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    if (map[k,j] is Hero)
                    {
                        //////////////
                        Player.vision[0] = map[k + 1, j];
                        Player.vision[0] = map[k + 1, j];
                        Player.vision[0] = map[k + 1, j];
                        Player.vision[0] = map[k + 1, j];


                    }
                    else if (map[k,j] is Enemy)
                    {
                        enemies[0].vision[0] = map[k + 1, j];
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
                for (int k = 0; k < enemies.Length; k++)
                {
                    enemies[k] = new SwampCreature(xCoord, yCoord, 10, 10, 1, (char)190);
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
                xCoord = rand.Next(1, mapWidth);
                yCoord = rand.Next(1, mapHeight);
            }
            while (map[xCoord, yCoord] is not EmptyTile);

            //Create Entity
            if (type == Tile.TileType.Hero)
                return new Hero(xCoord, yCoord, 10, 10, 2, (char)208);
            else if (type == Tile.TileType.Enemy)
                return new SwampCreature(xCoord, yCoord, 10, 10, 2, (char)190);
            else return new EmptyTile(xCoord, yCoord);
        }
    }
}
