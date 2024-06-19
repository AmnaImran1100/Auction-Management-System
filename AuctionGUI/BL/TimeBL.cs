using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGUI.BL
{
    class TimeBL
    {
        private int day;
        private int enteredTime;
        private int duration;

        public TimeBL()
        {

        }

        public TimeBL(int day, int enteredTime, int duration)
        {
            this.Day = day;
            this.EnteredTime = enteredTime;
            this.Duration = duration;
        }

        public int Day { get => day; set => day = value; }
        public int EnteredTime { get => enteredTime; set => enteredTime = value; }
        public int Duration { get => duration; set => duration = value; }
    }
}
