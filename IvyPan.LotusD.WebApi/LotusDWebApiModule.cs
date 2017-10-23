using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace IvyPan.LotusD
{
    [DependsOn(typeof(AbpWebApiModule), typeof(LotusDApplicationModule))]
    public class LotusDWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(LotusDApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
