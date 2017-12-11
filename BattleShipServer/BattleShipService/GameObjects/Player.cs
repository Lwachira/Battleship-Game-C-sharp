using System;
using System.Collections.Generic;

namespace BattleShipService
{
    enum BoardPlacement
    {
        Open = -1,
        Boat = 0,
        Destroyer = 1,
        Submarine = 2,
        Battleship = 3,
        Carrier = 4,
        Shot = 5,
        miss = 6
    }

    public class Player
    {
        private static Random rd = new Random();
        public Player(string name, int id)
        {
            Name = name;
            UID = id;
            Ready = false;
            ships = new List<Ship>();
            Turn = false;
        }

        private List<Ship> ships;
        int[,] grid;

        public int UID { get; private set; }
        public string Name { get; set; }
        public bool Turn { get; set; }
        public int[,] Board { get { return grid; } }
        public bool Ready { get; private set; }

        public void SetupGrid()
        {
            grid = new int[10, 10]
            {
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }
            };
            foreach(Ship s in ships)
            {
                if(s.Horizontal)
                {
                    for (int i = 0; i < s.HP; i++)
                        grid[(s.X/32) + i, (s.Y/32)] = (int)s.BoardPlacement;
                }
                else
                {
                    for (int i = 0; i < s.HP; i++)
                        grid[(s.X/32), (s.Y/32) + i] = (int)s.BoardPlacement;
                }
            }
            Ready = true;
        }
        public bool shoot(int x, int y)
        {
            if (grid[x, y] > (int)BoardPlacement.Open && grid[x, y] < (int)BoardPlacement.Shot)
            {
                ships[grid[x, y]].hit(x, y);
                grid[x, y] = (int)BoardPlacement.Shot;
                return true;
            }
            else if (grid[x, y] == (int)BoardPlacement.Open)
            {
                grid[x, y] = (int)BoardPlacement.miss;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddShip(shipPlacement placement)
        {
            switch (placement.placement)
            {
                case PlaceMode.HCarrier:
                    if (placement.x / 32 > 10 - 5 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 || placement.y < 0)
                        return false;
                    ships.Add(new AircraftCarrier(placement.x, placement.y, true, BoardPlacement.Carrier));
                    return true;
                case PlaceMode.HBattleship:
                    if (placement.x / 32 > 10 - 4 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 || placement.y < 0)
                        return false;
                    ships.Add(new Battleship(placement.x, placement.y, true, BoardPlacement.Battleship));
                    return true;
                case PlaceMode.HSubmarine:
                    if (placement.x / 32 > 10 - 3 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 || placement.y < 0)
                        return false;
                    ships.Add(new Submarine(placement.x, placement.y, true, BoardPlacement.Submarine));
                    return true;
                case PlaceMode.HDestroyer:
                    if (placement.x / 32 > 10 - 3 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 || placement.y < 0)
                        return false;
                    ships.Add(new Destroyer(placement.x, placement.y, true, BoardPlacement.Destroyer));
                    return true;
                case PlaceMode.HBoat:
                    if (placement.x / 32 > 10 - 2 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 || placement.y < 0)
                        return false;
                    ships.Add(new PatrolBoat(placement.x, placement.y, true, BoardPlacement.Boat));
                    return true;
                case PlaceMode.VCarrier:
                    if (placement.x / 32 > 10 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 - 5 || placement.y < 0)
                        return false;
                    ships.Add(new AircraftCarrier(placement.x, placement.y, false, BoardPlacement.Carrier));
                    return true;
                case PlaceMode.VBattleship:
                    if (placement.x / 32 > 10 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 - 4 || placement.y < 0)
                        return false;
                    ships.Add(new Battleship(placement.x, placement.y, false, BoardPlacement.Battleship));
                    return true;
                case PlaceMode.VSubmarine:
                    if (placement.x / 32 > 10 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 - 3 || placement.y < 0)
                        return false;
                    ships.Add(new Submarine(placement.x, placement.y, false, BoardPlacement.Submarine));
                    return true;
                case PlaceMode.VDestroyer:
                    if (placement.x / 32 > 10 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 - 3 || placement.y < 0)
                        return false;
                    ships.Add(new Destroyer(placement.x, placement.y, false, BoardPlacement.Destroyer));
                    return true;
                case PlaceMode.VBoat:
                    if (placement.x / 32 > 10 || placement.x < 0)
                        return false;
                    if (placement.y / 32 > 10 - 2 || placement.y < 0)
                        return false;
                    ships.Add(new PatrolBoat(placement.x, placement.y, false, BoardPlacement.Boat));
                    return true;
            }
            return false;
        }
    }
}
