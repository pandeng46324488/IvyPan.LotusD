using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using IvyPan.LotusD.EntityFramework;

namespace IvyPan.LotusD
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(LotusDCoreModule))]
    public class LotusDDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<LotusDDbContext>(null);
        }
    }
}
