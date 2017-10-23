using System.Reflection;
using Abp.Modules;

namespace IvyPan.LotusD
{
    [DependsOn(typeof(LotusDCoreModule))]
    public class LotusDApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
