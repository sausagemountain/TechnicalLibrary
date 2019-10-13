using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;

namespace Library
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(string nameOrConnectionString) : base(new SQLiteConnection(nameOrConnectionString), true)
        {
            Database.CreateIfNotExists();
        }
    }
}