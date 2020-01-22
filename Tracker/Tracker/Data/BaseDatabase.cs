using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Tracker.Data
{
    public class BaseDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        public static SQLiteAsyncConnection Database => lazyInitializer.Value;
        //public static bool initialized = false;

    }
}
