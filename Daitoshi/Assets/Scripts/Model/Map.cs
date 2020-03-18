using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Daitoshi
{
    public class Map
    {
        Tile[,] tiles;
        public int width;
        public int height;

        public Map(int width = 10, int height = 10)
        {
            this.width = width;
            this.height = height;

            tiles = new Tile[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    tiles[x,y] = new Tile(x, y, TileType.Grass);
                }
            }

            Debug.Log($"created {width * height} tiles lit");
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x < 0 || x > width || y < 0 || y > height)
            {
                Debug.LogError("Tile index out of range");
                return null;
            }
            return tiles[x, y];
        }
    }
}