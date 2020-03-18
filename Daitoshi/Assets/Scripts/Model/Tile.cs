// Caden 2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Daitoshi
{
    public class Tile
    {
        TileType type;
        public int x;
        public int y;

        public Tile(int x, int y, TileType type)
        {
            this.x = x;
            this.y = y;
        }
    }
}


