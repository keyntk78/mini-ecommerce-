using MiniEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MiniEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MiniEcommerceController : AbpControllerBase
{
    protected MiniEcommerceController()
    {
        LocalizationResource = typeof(MiniEcommerceResource);
    }
}
