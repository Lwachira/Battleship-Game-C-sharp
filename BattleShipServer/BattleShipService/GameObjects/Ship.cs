using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    abstract class Ship
    {
        public Ship(string name,int hp, int x, int y, bool horizontal,BoardPlacement placement)
        {
            Name = name;
            BattleReady = new BattleReadyState(this);
            TakingOnWater = new TakingOnWaterState(this);
            Sunk = new SunkState(this);
            Current = BattleReady;
            X = x;
            Y = y;
            Horizontal = horizontal;
            hitpoints = new List<int[]>();

            if(horizontal)
                for (int i = 0; i < hp; i++)
                    hitpoints.Add(new int[] { x + i, y });
            else
                for (int i = 0; i < hp; i++)
                    hitpoints.Add(new int[] { x, y + i});
            BoardPlacement = placement;
        }

        public IShipState Current { get; set; }
        public IShipState BattleReady { get; private set; }
        public IShipState TakingOnWater { get; private set; }
        public IShipState Sunk { get; private set; }
        public BoardPlacement BoardPlacement { get; private set; }

        public string Name { get; private set; }
        public int HP { get { return hitpoints.Count; } }
        public int X { get; private set; }
        public int Y { get; private set; }
        private List<int[]> hitpoints;
        public bool Horizontal { get; private set; }

        public string hit(int x, int y)
        {
            for(int i = 0; i < HP; i++)
            {
                if(hitpoints[i][0] == x && hitpoints[i][1] == y)
                {
                    hitpoints.RemoveAt(i);
                    return Current.Hit();
                }
            }
            return "";
        }
    }
}
