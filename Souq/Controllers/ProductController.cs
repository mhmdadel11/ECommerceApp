using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Souq.Migrations;
using Souq.Models;

namespace Souq.Controllers
{
    public class ProductController : Controller
    {
        SouqContext db = new SouqContext();
        public IActionResult Index()
        {
            SouqContext db = new SouqContext();      // ده عشان تعمل الدروب داون ليست 
            var list = db.Categories.Select(x => new { x.Id, x.Name }).ToList();
            ViewBag.CatList = new SelectList(list, "Id", "Name");

            return View();
        }


        public IActionResult Charts()
        {
            return View();
        }

        //*/https://localhost:44370/Product/getAllProducts*/
        public IActionResult getProducts()
        {
            return Ok(db.Products.ToList());
        }




        [HttpPost]
        public IActionResult Create(ProductVM model)
        {
            if (ModelState.IsValid)  // لو صح رجعنى للاندكس
            {
                SouqContext db = new SouqContext();    //هنا انشأت كاتجورى وضفتها ف داتا بيز
                //يضيف بيانات فالمنتج
                Category c = new Category();
                c.Name = model.CatName;
                    
                db.Categories.Add(c);

                //يضيف بيانات ف المنتج
                db.Products.Add(new Product            //انشأت برودكت وضفتها فالداتابيز
                                     { Name = model.ProductName,
                                      Price = model.ProductPrice,
                                      Quantity = (int)model.ProductQty,
                                      Cat = c
                                     });
                db.SaveChanges();
                return View("Index");
            }
            return View("Index",model); //يرجعني لنفس الانديكس بس يديني الموديل بتاعى لو حصل اى خطأ
        }
    }
}
