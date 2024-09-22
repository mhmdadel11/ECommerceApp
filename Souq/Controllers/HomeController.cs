using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souq.Models;
using System.Diagnostics;

namespace Souq.Controllers
{
    public class HomeController : Controller
    {

        SouqContext db = new SouqContext();
        public IActionResult Index()
        {
            indexVm result = new indexVm();  // عملت object و حطيت فيه كل البيانات

            result.Categories = db.Categories.ToList();
            result.Products = db.Products.ToList();
            result.Reviews = db.Reviews.ToList();

            result.LatestProducts = db.Products.OrderByDescending(x => x.EntryDate).Take(4).ToList();
            return View(result);

            //Another Solution

            //var cats = db.Categories.ToList();
            //var products = db.Products.ToList();
            //var reviews = db.Reviews.ToList();



            //indexVm result = new indexVm();  // عملت object و حطيت فيه كل البيانات 
            //result.Categories = cats;
            //result.Products = products;
            //result.Reviews = reviews;
            //return View(result);

        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Categories()
        {
           
            var cats = db.Categories.ToList();
            return View(cats);
        }

        public IActionResult Products(int id)
        {
            var Products = db.Products.Where(x => x.CatId == id).ToList();
            return View(Products);
        }

        public IActionResult currentProduct(int id)
        {
            var Product = db.Products.Include(x=>x.Cat).Include(x=>x.ProductImages).FirstOrDefault(x => x.Id == id);      // ده عشان لما يبحث عن منتج يبعته لل فيو
            return View(Product);
        }
        [HttpGet]
        public IActionResult productSearch(string xname)
        {
            var Products = new List<Product>();
            if (string.IsNullOrEmpty(xname))       //ده عشان لو جيت ابحث ومكتبتش حاجه يجبلي كل المنتجات
                Products = db.Products.ToList();
            else
                  Products = db.Products.Where(x => x.Name.Contains(xname)).ToList();
            return View(Products);
        }
        // ده جزء ال contact
        [HttpPost  ]
        public IActionResult sendreview(ReviewVM model)
        {
            string x = model.age;
            db.Reviews.Add(new Review { Name =model.Name, Email = model.Email, Subject = model.Subject, Description = model.Description });
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}