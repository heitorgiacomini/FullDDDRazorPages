using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace livraria.Web;

[Dependency(ReplaceServices = true)]
public class livrariaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "livraria";
}
