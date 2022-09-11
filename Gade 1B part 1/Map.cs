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

            Enemies = new Enemy[amtEnemies];
            //Spawn Hero
            DeleteThisCreate(Tile.TileType.Hero);
            //Spawn enemies
            DeleteThisCreate(Tile.TileType.Enemy);


            //for (int k = 0; k < enemies.Length; k++)
            //{
            //    enemies[k] = Create(Tile.TileType.Enemy);
            //}

            UpdateVision();
        }

        //Q3.2/////////////not finished yet/////////////
        public void UpdateVision()
        {
            for (int k = 0; k < MapWidth; k++)
            {
                for (int j = 0; j < MapHeight; j++)
                {
                    if (map[k,j] != null)
                    {
                        //map[k, j]
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
                xCoord = rand.Next(1, mapWidth);
                yCoord = rand.Next(1, mapHeight);
            }
            while (map[xCoord, yCoord] is not EmptyTile);

            //Create Entity
            return new Hero(xCoord, yCoord, 10, 10, 2, (char)208);
        }
    }
}
