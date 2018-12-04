using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeighMan.Model
{
   public class WeighManContext : DbContext
    {

        public WeighManContext() : base()
        {
             
            //Database.SetInitializer<POSDataContext>(new CreateDatabaseIfNotExists<POSDataContext>());

            //Database.SetInitializer<WeighManContext>(new MigrateDatabaseToLatestVersion<WeighManContext, Migrations.Configuration>());
            Database.Initialize(false);

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<WeighConfigMaster> WeighConfigMasters { get; set; }
        public DbSet<WeightData> WeightDatas { get; set; }

        
    }

}
