using MiniEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MiniEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MiniEcommerceAdminController : AbpControllerBase
{
    protected MiniEcommerceAdminController()
    {
        LocalizationResource = typeof(MiniEcommerceResource);
    }
}
