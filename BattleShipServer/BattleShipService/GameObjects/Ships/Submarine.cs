using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class Submarine : Ship
    {
        public Submarine(int x, int y, bool horizontal, BoardPlacement placement) : base("Submarine", 3,x,y,horizontal, placement)
        {

        }
    }
}
