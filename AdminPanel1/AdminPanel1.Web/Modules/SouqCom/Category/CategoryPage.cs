using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel1.SouqCom.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("SouqCom/Category")]
    public ActionResult Index()
    {
        return this.GridPage("@/SouqCom/Category/CategoryPage",
            CategoryRow.Fields.PageTitle());
    }
}