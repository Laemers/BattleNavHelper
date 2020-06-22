using System.Collections.Generic;

namespace BattleNavHelper
{
    public class Ram
    {
        public static readonly Ram SLOOP = new Ram("Sloop", 0.5, 0.333, 0.25);
        public static readonly Ram CUTTER = new Ram("Cutter", 0.5, 0.333, 0.25);
        public static readonly Ram DHOW = new Ram("Dhow", 0.5, 0.333, 0.25);
        public static readonly Ram FANCHUAN = new Ram("Fanchuan", 0.5, 0.333, 0.25);
        public static readonly Ram LONGSHIP = new Ram("LongRam", 0.5, 0.333, 0.25);
        public static readonly Ram BAGHLAH = new Ram("Baghlah", 1, 0.667, 0.5);
        public static readonly Ram MERCHANTBRIG = new Ram("Merchant brig", 1, 0.667, 0.5);
        public static readonly Ram JUNK = new Ram("Junk", 1.5, 1, 0.75);
        public static readonly Ram WARBRIG = new Ram("War brig", 2, 1.333, 1);
        public static readonly Ram MERCHANTGALEON = new Ram("Merchant galleon", 2.5, 1.667, 1.25);
        public static readonly Ram XEBEC = new Ram("Xebec", 2.5, 1.667, 1.25);
        public static readonly Ram WARFRIGATE = new Ram("War frigate", 3, 2, 1.5);
        public static readonly Ram GRANDFRIGATE = new Ram("Grand frigate", 4, 2.667, 2);

        public static IEnumerable<Ram> Values
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
        public double Small_Eq { get; private set; }
        public double Medium_Eq { get; private set; }
        public double Large_Eq { get; private set; }


        Ram(string name, double small_eq, double medium_eq, double large_eq) =>
            (Name, Small_Eq, Medium_Eq, Large_Eq) =
            (name, small_eq, medium_eq, large_eq);
    }
}