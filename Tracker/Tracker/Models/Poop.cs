using SQLite;

namespace Tracker.Models
{
    class Poop
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Date { get; set; } // ISO string format: YYY-MM-DD HH:MM:SS.SSS

        public int Scale { get; set; } //Bristol stool rating scale 1-7


    }
}
