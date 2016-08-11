using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter.Library
{
    public class Sitter
    {
        string bedTime;
        string startHour;
        string endHour;

        //Represent work hours
        static string[] workHours = { "5 PM", "6 PM", "7 PM", "8 PM", "9 PM", "10 PM", "11 PM", "12 AM", "1 AM", "2 AM", "3 AM", "4 AM" };
        static WorkHourLabel[] workHourLabel = null;

        public Sitter()
        {
            workHourLabel = new WorkHourLabel[12];
        }

        public enum WorkHourLabel
        {
            StartTimeToBetTimeRange,
            BedTimeToMidNightRange,
            MidNightToFinalHoursRange
        }

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
        private int getElementPosition(string workHourElement)
        {
            int bedTimePosition = 0;
            for (int anIndex = 0; anIndex < workHours.Length; anIndex++)
            {
                if (workHourElement == workHours[anIndex])
                {
                    bedTimePosition = anIndex;
                    break;
                }
            }
            return bedTimePosition;
        }
        public int getPayCharge(string bedTime, string startTime, string endTime)
        {
            int bedTimePosition = 0;
            int startingHourPosition = 0;
            int endHourPosition = 0;
            int StartTimeToBetTimeRangeHourCounter = 0;
            int BedTimeToMidNightRangeHourCounter = 0;
            int MidNightToFinalHoursRangeHOurCounter = 0;
            this.bedTime = bedTime;
            this.startHour = startTime;
            this.endHour = endTime;
            bool isEndTimeEncountered = false;


            bedTimePosition = getElementPosition(this.bedTime);
            startingHourPosition = getElementPosition(this.startHour);
            endHourPosition = getElementPosition(this.endHour);

            for (int anIndex = 0; anIndex < workHours.Length; anIndex++)
            {
                if (anIndex < bedTimePosition)  //begining earliest can that work can begin
                    workHourLabel[anIndex] = WorkHourLabel.StartTimeToBetTimeRange;
                else if (anIndex >= bedTimePosition && anIndex <= 7) //midnight position is 7 within array
                    workHourLabel[anIndex] = WorkHourLabel.BedTimeToMidNightRange;
                else
                {

                    workHourLabel[anIndex] = WorkHourLabel.MidNightToFinalHoursRange;

                }

            }

            for (int anIndex = startingHourPosition; anIndex < workHours.Length; anIndex++)
            {
                if (workHours[anIndex] == this.endHour)
                    isEndTimeEncountered = true;

                if (workHourLabel[anIndex] == WorkHourLabel.StartTimeToBetTimeRange && anIndex < bedTimePosition && isEndTimeEncountered == false)
                    StartTimeToBetTimeRangeHourCounter++;
                else if (workHourLabel[anIndex] == WorkHourLabel.BedTimeToMidNightRange && anIndex >= bedTimePosition && anIndex < 7 && isEndTimeEncountered == false)
                    BedTimeToMidNightRangeHourCounter++;
                else
                {
                    if (isEndTimeEncountered == false)
                        MidNightToFinalHoursRangeHOurCounter++;

                }
            }

            return StartTimeToBedTimeCharge(StartTimeToBetTimeRangeHourCounter) + BedTimeToMidnightCharge(BedTimeToMidNightRangeHourCounter) + MidnightToEndTimeCharge(MidNightToFinalHoursRangeHOurCounter);
        }
    }
}
