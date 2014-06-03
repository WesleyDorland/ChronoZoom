﻿using Chronozoom.Entities.Migration;
using System;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;

namespace Chronozoom.Entities
{
    /// <summary>
    /// Describes storage migration options. Used when a schema upgrade is required.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses")]
    class StorageMigrationsConfiguration : DbMigrationsConfiguration<Storage>
    {
        protected override void Seed(Storage context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            Trace.TraceInformation("Entering storage seed stage");

            Migrator migrator = new Migrator(context);
            migrator.Migrate();
        }

        public StorageMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
