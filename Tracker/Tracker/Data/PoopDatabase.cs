using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using Tracker.Models;

namespace Tracker.Data
{
    class PoopDatabase : BaseDatabase
    {
        static bool initialized = false;
        
        public PoopDatabase()
        {
            InitializePoopAsync().SafeFireAndForget(false);
        }

        public static PoopDatabase DB = new PoopDatabase();

        async Task InitializePoopAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Poop).Name))
                {
                    await Database.CreateTableAsync(typeof(Poop)).ConfigureAwait(false);

                    initialized = true;
                }
            }
        }

        internal Task<List<Poop>> GetPoopsAsync()
        {
            return Database.Table<Poop>().ToListAsync();
        }

        public Task<int> SavePoopAsync(Poop poop)
        {
            if (poop.ID != 0)
            {
                return Database.UpdateAsync(poop);
            }
            else
            {
                return Database.InsertAsync(poop);
            }
        }

        public Task<int> DeletePoopAsync(Poop poop)
        {
            return Database.DeleteAsync(poop);
        }
    }
}
