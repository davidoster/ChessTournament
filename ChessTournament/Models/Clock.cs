using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.Models
{
    class Clock : Naming
    {
        private int _totaltime;

        public int TotalTime
        {
            get { return _totaltime; }
            set { _totaltime = value; }
        }

        private int _tick;

        public int TickStep
        {
            get { return _tick; }
            set { _tick = value; }
        }


        public Clock()
        {
            Console.WriteLine("This is a Clock!");
            this._totaltime = 15; // 15 seconds
            this._tick = 15;
        }

        public Clock(int TotalTime)
        {
            this._totaltime = TotalTime;
            this._tick = 15;
        }

        public Clock(string Name)
        {
            this.Name = Name;

        }

        public int Tick()
        {
            return (this._totaltime -= this._tick);
        }
    }
}
