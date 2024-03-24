using Fountain_of_Objects.Classes;
using Fountain_of_Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Structs
{
    public struct MapLocation
    {
        public int X { get; set; }

        public int Y { get; set; }

        public MapLocation(int x, int y)
        {
            X = x; 
            Y = y;
        }

        /// <summary>
        /// Determines the location of the fountain tile and returns its X and Y postions
        /// </summary>
        /// <param name="map">The map you want to find the fountain location of</param>
        /// <param name="rowSize">size of x dimention of the map</param>
        /// <param name="colSize">size of y dimention of the map</param>
        /// <returns>The fountains x and y positions to the FountainLocation struct Type</returns>
        public MapLocation GetFountainLocation(ITiles[,] map, int rowSize, int colSize)
        {
            FountainTile testTile = new FountainTile();

            //run through entire map until the fountain tile is found. Log the coordinates and return location.
            for(int row = 0; row < rowSize; row++)
            {
                for(int col = 0; col < colSize; col++)
                {
                    if (map[row, col].GetType() == testTile.GetType())
                    {
                        MapLocation location = new MapLocation(row, col);
                        return location;
                    }
                }
            }

            Console.WriteLine("Error. No fountain tile found in given map. There could be an error with the map construction method.");
            return default(MapLocation);
        }


    }
}
