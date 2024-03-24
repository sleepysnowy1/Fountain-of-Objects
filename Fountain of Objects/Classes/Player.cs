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
        MapLocation _playersLocation;
        public MapLocation playerLocation { get => _playersLocation; set => this.playerLocation = _playersLocation; }
        
        public bool IsDead { get ; set; }

        public void MoveEast()
        {
            throw new NotImplementedException();
        }

        public void MoveNorth()
        {
            throw new NotImplementedException();
        }

        public void MoveSouth()
        {
            _playersLocation.X += 1;
        }

        public void MoveWest()
        {
            throw new NotImplementedException();
        }
    }
}
