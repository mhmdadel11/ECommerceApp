using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel1.Product.Pages;

[PageAuthorize(typeof(ProductRow))]
public class ProductPage : Controller
{
    [Route("Product/Product")]
    public ActionResult Index()
    {
        return this.GridPage("@/Product/Product/ProductPage",
            ProductRow.Fields.PageTitle());
    }
}