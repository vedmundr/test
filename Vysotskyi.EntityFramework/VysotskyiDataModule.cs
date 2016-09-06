using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Vysotskyi.EntityFramework;

namespace Vysotskyi
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(VysotskyiCoreModule))]
    public class VysotskyiDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<VysotskyiDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
