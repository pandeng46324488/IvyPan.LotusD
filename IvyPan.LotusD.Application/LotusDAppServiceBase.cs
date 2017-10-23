using Abp.Application.Services;

namespace IvyPan.LotusD
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class LotusDAppServiceBase : ApplicationService
    {
        protected LotusDAppServiceBase()
        {
            LocalizationSourceName = LotusDConsts.LocalizationSourceName;
        }
    }
}