using Fountain_of_Objects.Classes;
using Fountain_of_Objects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILevel level = new Level();

            level.GenerateLevel();

            level.GameStart();
            //level.PrintMap();
            
        }
    }
}
