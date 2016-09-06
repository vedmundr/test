using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Vysotskyi.EntityFramework;

namespace Vysotskyi.Migrator
{
    [DependsOn(typeof(VysotskyiDataModule))]
    public class VysotskyiMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<VysotskyiDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}