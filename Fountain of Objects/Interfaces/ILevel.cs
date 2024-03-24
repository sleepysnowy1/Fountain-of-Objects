using Fountain_of_Objects.Classes;
using Fountain_of_Objects.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Interfaces
{
    internal interface ILevel
    {
        List<ITiles[,]> Levels { get; set; }

        MapLocation fountainLocation { get; set; }
        IPlayer player { get; set; }
        
        bool FountainFound { get; set; }
        void PrintMap();
        void GenerateLevel();
        void LevelWon();
        void GameStart();

    }
}
