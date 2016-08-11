using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Library
{
    public class Sitter
    {
        public int StartTimeToBedTimeCharge(int startTimeToBedTimeHours)
        {
            int rate;
            rate = 12;
            return startTimeToBedTimeHours * rate;
        }

        public int BedTimeToMidnightCharge(int bedTimeToMidNightHours)
        {
            int rate;
            rate = 8;
            return bedTimeToMidNightHours * rate;
        }
    }
}
