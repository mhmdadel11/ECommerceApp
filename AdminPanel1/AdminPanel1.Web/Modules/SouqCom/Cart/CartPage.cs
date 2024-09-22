using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel1.SouqCom.Pages;

[PageAuthorize(typeof(CartRow))]
public class CartPage : Controller
{
    [Route("SouqCom/Cart")]
    public ActionResult Index()
    {
        return this.GridPage("@/SouqCom/Cart/CartPage",
            CartRow.Fields.PageTitle());
    }
}