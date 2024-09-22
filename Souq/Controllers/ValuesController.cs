using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Souq.Models;

namespace Souq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //SouqContext db = new SouqContext();
        ////api
        ////*/https://localhost:44370/Product/getAllProducts*/

        //[HttpGet("getProducts")]
        //public IActionResult getProducts()
        //{
            
        //    return Ok(db.Products.Include(x=>x.Cat).ToList());   /*بجيب بيانات جدول الكاتجورى و برودكت*/
        //}
        //[HttpGet("getCategories")]
        //public IActionResult getCats()
        //{
           
        //    return Ok(db.Categories.ToList());
        //}

    }
}
