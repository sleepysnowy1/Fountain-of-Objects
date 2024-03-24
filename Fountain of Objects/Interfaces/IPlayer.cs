using Fountain_of_Objects.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Interfaces
{
    public interface IPlayer
    {
        public MapLocation playerLocation { get; set; }

        public bool IsDead { get; set; }
        void MovePlayer(ITiles[,] map);
        


    }
}
