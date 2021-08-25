namespace Migrator
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new FileLogger("C:\\Files\\Log.txt"));
            dbMigrator.Migrate();
        }
    }
}

