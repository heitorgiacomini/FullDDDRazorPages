using System;
using System.Collections.Generic;
using System.Text;
using livraria.Localization;
using Volo.Abp.Application.Services;

namespace livraria;

/* Inherit your application services from this class.
 */
public abstract class livrariaAppService : ApplicationService
{
    protected livrariaAppService()
    {
        LocalizationResource = typeof(livrariaResource);
    }
}
