using Fountain_of_Objects.Interfaces;
using Fountain_of_Objects.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Classes
{
    public class Player : IPlayer
    {   
        //backing fields 
        private MapLocation _playersLocation;
        private bool _isDead; 

        //properties
        public MapLocation playerLocation { get => _playersLocation; set => this.playerLocation = _playersLocation; }
        public bool IsDead { get => _isDead ; set => _isDead = value; }

        //constructors
        public Player (MapLocation playersLocation, bool isDead )
        {
            this.playerLocation = playersLocation;
            _isDead = isDead;
        }
        public Player()
        {
            _isDead = false;
            _playersLocation.X = 0;
            _playersLocation.Y = 0;
        }

        //methods
        public void MovePlayer(ITiles[,] map)
        {
            Console.WriteLine();
            //first determine where the player can move
            
            try
            {
                if (map[playerLocation.X - 1, playerLocation.Y] != null)
                {
                    Console.Write("You can move west");
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.Write("The way to the west is blocked");
            }
            try
            {
                if(map[playerLocation.X + 1, playerLocation.Y] != null)
                {
                    Console.Write("\nYou can move to the east"); 
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("\nThe way to the east is blocked."); 
            }
            try
            {
                if (map[playerLocation.X, playerLocation.Y + 1] != null)
                {
                    Console.Write("\nYou can move to the north.");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("\nThe way to the north is blocked.");
            }
            try
            {
                if (map[playerLocation.X, playerLocation.Y-1] != null)
                {
                    Console.Write("\nYou can move to the south");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("\nThe way to the south is blocked.");
            }



        }
        private void MoveNorth()
        {
            _playersLocation.Y += 1;
        }

        private void MoveSouth()
        {
            _playersLocation.Y += -1;
        }

        private void MoveWest()
        {
            _playersLocation.X += -1;
        }
        private void MoveEast()
        {
            _playersLocation.X += 1;
        }
    }
}
