using System;
using DbUp.Engine;

namespace DatabaseMigrations
{
    public class DatabaseUpgradeFailedException : Exception
    {
        public DatabaseUpgradeResult Result { get; private set; }

        public DatabaseUpgradeFailedException(DatabaseUpgradeResult result)
        {
            Result = result;
        }
    }
}