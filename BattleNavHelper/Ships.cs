using System.Collections.Generic;

namespace BattleNavHelper
{
    public class Ship
    {
        public static readonly Ship SLOOP = new Ship("Sloop", "Small", 6, 4, 3);
        public static readonly Ship CUTTER = new Ship("Cutter", "Small", 7.5, 5, 3.75);
        public static readonly Ship DHOW = new Ship("Dhow", "Medium", 7.5, 5, 3.75);
        public static readonly Ship FANCHUAN = new Ship("Fanchuan", "Large", 7.875, 5.225, 3.9375);
        public static readonly Ship LONGSHIP = new Ship("Longship", "Small", 9, 6, 4.5);
        public static readonly Ship BAGHLAH = new Ship("Baghlah", "Medium", 12, 8, 6);
        public static readonly Ship MERCHANTBRIG = new Ship("Merchant brig", "Medium", 12, 8, 6);
        public static readonly Ship JUNK = new Ship("Junk", "Large", 15, 10, 7.5);
        public static readonly Ship WARBRIG = new Ship("War brig", "Medium", 15, 10, 7.5);
        public static readonly Ship MERCHANTGALEON = new Ship("Merchant galleon", "Large", 18, 12, 9);
        public static readonly Ship XEBEC = new Ship("Xebec", "Medium", 21, 14, 10.5);
        public static readonly Ship WARFRIGATE = new Ship("War frigate", "Large", 30, 20, 15);
        public static readonly Ship GRANDFRIGATE = new Ship("Grand frigate", "Large", 36, 24, 18);

        public static IEnumerable<Ship> Values
        {
            get
            {
                yield return SLOOP;
                yield return CUTTER;
                yield return DHOW;
                yield return FANCHUAN;
                yield return LONGSHIP;
                yield return BAGHLAH;
                yield return MERCHANTBRIG;
                yield return JUNK;
                yield return WARBRIG;
                yield return MERCHANTGALEON;
                yield return XEBEC;
                yield return WARFRIGATE;
                yield return GRANDFRIGATE;
            }
        }

        public string Name { get; private set; }
        public string Cannon_Size { get; private set; }
        public double Max_Small { get; private set; }
        public double Max_Medium { get; private set; }
        public double Max_Large { get; private set; }


        Ship(string name, string cannon_size, double max_small, double max_medium, double max_large) =>
            (Name, Cannon_Size, Max_Small, Max_Medium, Max_Large) =
            (name, cannon_size, max_small, max_medium, max_large);
    }
}