using livraria.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace livraria.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class livrariaController : AbpControllerBase
{
    protected livrariaController()
    {
        LocalizationResource = typeof(livrariaResource);
    }
}
