using System.Reflection;
using Abp.Modules;

namespace IvyPan.LotusD
{
    public class LotusDCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
