﻿using System;
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

        public int MidnightToEndTimeCharge(int midNightToEndTimeHOurs)
        {
            int rate = 16;
            return midNightToEndTimeHOurs * rate;
        }

        public int getPayCharge(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}
