using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;

namespace Library
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(string nameOrConnectionString) : base(new SQLiteConnection(nameOrConnectionString, true), true)
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<LibraryUser> LibraryUsers { get; set; }
        public DbSet<PassOutRecord> PassOutRecords { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<WorkerInfo> WorkerInfos { get; set; }
    }
}