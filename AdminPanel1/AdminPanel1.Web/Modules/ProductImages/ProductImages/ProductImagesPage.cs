using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel1.ProductImages.Pages;

[PageAuthorize(typeof(ProductImagesRow))]
public class ProductImagesPage : Controller
{
    [Route("ProductImages/ProductImages")]
    public ActionResult Index()
    {
        return this.GridPage("@/ProductImages/ProductImages/ProductImagesPage",
            ProductImagesRow.Fields.PageTitle());
    }
}