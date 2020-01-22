using SQLite;
using System;

namespace Tracker.Models
{
    class Poop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        private string _date;

        public string Date {
            get { return _date; }
            set { _date = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.s"); } // ISO string format: YYY-MM-DD HH:MM:SS.SSS
        }
        public int Scale { get; set; } //Bristol stool rating scale 1-7


    }
}
