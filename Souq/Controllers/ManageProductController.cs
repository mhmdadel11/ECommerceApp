using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souq.Models;

namespace Souq.Controllers
{
    public class ManageProductController : Controller
    {
        SouqContext db = new SouqContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getProducts")]
        public IActionResult getProducts()
        {

            return Ok(db.Products.Include(x => x.Cat).ToList());   /*بجيب بيانات جدول الكاتجورى و برودكت*/
        }
    }
}
