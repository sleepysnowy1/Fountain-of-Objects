using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountain_of_Objects.Interfaces
{
    public interface IGameDisplay
    {
        void ShowNextRound(IPlayer player, ITiles[,] map);
    }
}
