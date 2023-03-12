using System;
using System.Collections.Generic;
using System.Text;
using MiniEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace MiniEcommerce;

/* Inherit your application services from this class.
 */
public abstract class MiniEcommerceAppService : ApplicationService
{
    protected MiniEcommerceAppService()
    {
        LocalizationResource = typeof(MiniEcommerceResource);
    }
}
