using livraria.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace livraria.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class livrariaPageModel : AbpPageModel
{
    protected livrariaPageModel()
    {
        LocalizationResourceType = typeof(livrariaResource);
    }
}
