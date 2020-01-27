using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.Models
{
    // class used to access "sqlite_master" table in the SQLite DB 
    public class TableName
    {
        public TableName() { }
        public string name { get; set; }
    }
}
