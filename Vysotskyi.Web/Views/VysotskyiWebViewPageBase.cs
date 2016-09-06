using Abp.Web.Mvc.Views;

namespace Vysotskyi.Web.Views
{
    public abstract class VysotskyiWebViewPageBase : VysotskyiWebViewPageBase<dynamic>
    {

    }

    public abstract class VysotskyiWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected VysotskyiWebViewPageBase()
        {
            LocalizationSourceName = VysotskyiConsts.LocalizationSourceName;
        }
    }
}