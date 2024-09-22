using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel1.Review.Pages;

[PageAuthorize(typeof(ReviewRow))]
public class ReviewPage : Controller
{
    [Route("Review/Review")]
    public ActionResult Index()
    {
        return this.GridPage("@/Review/Review/ReviewPage",
            ReviewRow.Fields.PageTitle());
    }
}