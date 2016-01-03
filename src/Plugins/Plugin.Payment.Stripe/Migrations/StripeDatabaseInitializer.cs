using BeYourMarket.Core.Migrations;
using Plugin.Payment.Stripe.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Payment.Stripe.Migrations
{
    class StripeDatabaseMigrationConfig : DbMigrationsConfiguration<StripeContext>
    {
        public StripeDatabaseMigrationConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Plugin.Payment.Stripe.Data.StripeContext";

            TargetDatabase = new System.Data.Entity.Infrastructure.DbConnectionInfo("DefaultConnection");
        }

        protected override void Seed(StripeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }

    class StripeDatabaseInitializer : CreateAndMigrateDatabaseInitializer<StripeContext, StripeDatabaseMigrationConfig>
    {
        #region Constructor
        // pass user model, and database info
        public StripeDatabaseInitializer()
            : base()
        {
            InitializeDatabase(new StripeContext());
        }
        #endregion

        #region Methods
        protected override void Seed(StripeContext context)
        {
        }

        #endregion
    }
}
