using System;
using System.Linq;

namespace app
{
    public class BowlingFrames
    {
        public static IBowlingFrame From(Roll[] rolls)
        {
            int rollSum = rolls.Sum(roll => roll.RollValue);

            if(rollSum == 10 && rolls.Length == 1) return new StrikeFrame(rolls);
            if(rollSum == 10) return new SpareFrame(rolls);

            return new OpenFrame(rolls);
        }
    }
}
