using System;
using System.Collections.Generic;
using System.Text;
using MiniEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace MiniEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class MiniEcommerceAdminAppService : ApplicationService
{
    protected MiniEcommerceAdminAppService()
    {
        LocalizationResource = typeof(MiniEcommerceResource);
    }
}
