using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Microsoft.eShopWeb.Web.Basket;

[Authorize]
public class SuccessModel : PageModel
{
    public void OnGet()
    {

    }
}
