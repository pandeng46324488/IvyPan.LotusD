using Abp.Web.Mvc.Views;

namespace IvyPan.LotusD.Web.Views
{
    public abstract class LotusDWebViewPageBase : LotusDWebViewPageBase<dynamic>
    {

    }

    public abstract class LotusDWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LotusDWebViewPageBase()
        {
            LocalizationSourceName = LotusDConsts.LocalizationSourceName;
        }
    }
}