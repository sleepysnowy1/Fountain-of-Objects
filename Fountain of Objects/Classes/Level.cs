using Fountain_of_Objects.Interfaces;
using Fountain_of_Objects.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Classes
{
    internal class Level : ILevel
    {
        ITiles[,] _map = new ITiles[4, 4];
        public List<ITiles[,]> Levels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITiles[,] map
        {
            set => map = _map;

            get => _map;
        }
        public MapLocation fountainLocation { get; set; }
        public IPlayer player { get; set; }
        public bool FountainFound
        {
            get => this.FountainFound; 

            set
            {
                if (this.player.playerLocation.Equals(fountainLocation))
                {
                    this.FountainFound = true;
                }
            }
        }

        public bool GameWon
        {
            get => this.GameWon;

            set
            {
                if(player.playerLocation.X == 0 && player.playerLocation.Y == 0 && FountainFound == true)
                {
                    this.GameWon = true;
                }
            }
        }


        /// <summary>
        /// This method generates one level for the player to traverse it places the fountain in a random
        /// location.
        /// </summary>
        public void GenerateLevel()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            bool fountainPlaced = false; 
            Debug.Write("in gen level"); 

            //fill 2d tile array with nested for loops 
            for(int row = 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    //logic to which grid cells will be which tiles
                    if(row == 0 && col == 0)
                    {
                        map[row, col] = new CavernEnteranceTile(); 
                    }
                    else if(row == rnd.Next(2, 3) && col == rnd2.Next(1, 3) && fountainPlaced == false) //limit min row to 2 so fountain is generated farther away from entrance
                    {
                        map[row, col] = new FountainTile();
                        fountainLocation = new MapLocation(row, col);
                        fountainPlaced = true; 
                        Debug.WriteLine($"Row: {row}, Col: {col}");
                        Debug.WriteLine($"rnd: {rnd.Next(2 + 1)} rnd2: {rnd2.Next(2 + 1)}");
                    } 
                    else
                        map[row, col] = new EmptyTile(); 
                }
            }
        }

        public void LevelWon()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You activated the fountain and made it out with your life. Congrats!");
            Console.ForegroundColor= ConsoleColor.White;
        }

        /// <summary>
        /// Uses nested loops to run through the 2D map and print out all tiles
        /// </summary>
        public void PrintMap()
        {
            

            for(int row = 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    if (map[row, col] is EmptyTile)
                    {
                        Console.Write("0");
                    }
                    else if (map[row, col] is FountainTile)
                    {
                        Console.Write("*");
                    }
                    else if (map[row, col] is CavernEnteranceTile)
                    {
                        Console.Write(">");
                    }
                    
                }
                Console.WriteLine();
            }
        }//end method
         
        public void GameStart()
        {
            
            Console.Write("You arrive in the cave that is said to hold the "); Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Fountain of Objects."); Console.ForegroundColor= ConsoleColor.White;
            //do
            //{

            //}while(true);
        }

    }//end class
}//end namespace
