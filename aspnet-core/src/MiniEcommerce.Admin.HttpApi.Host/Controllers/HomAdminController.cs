using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace MiniEcommerce.Admin.Controllers;

public class HomAdminController : AbpController
{
    public ActionResult Index()
    {
        return Redirect("~/swagger");
    }
}
