using Abp.Web.Mvc.Controllers;

namespace IvyPan.LotusD.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class LotusDControllerBase : AbpController
    {
        protected LotusDControllerBase()
        {
            LocalizationSourceName = LotusDConsts.LocalizationSourceName;
        }
    }
}