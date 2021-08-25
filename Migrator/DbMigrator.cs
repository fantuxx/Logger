using System;
using System.Threading;

namespace Migrator
{
    public class DbMigrator
    {
        private readonly ILooger _logger;
        public DbMigrator(ILooger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogError("Migration started at:" + DateTime.Now);
            Thread.Sleep(1000);
            _logger.LogWarning("doing its job be patient");
            Thread.Sleep(1000);
            _logger.LogWarning("Loging and working and blah blah blah...");
             Thread.Sleep(1000);
            _logger.LogWarning("Few more seconds and it's gonna be done");
            Thread.Sleep(1000);
            _logger.LogInfo("Migration finished at:" + DateTime.Now);
        }
    }
}
