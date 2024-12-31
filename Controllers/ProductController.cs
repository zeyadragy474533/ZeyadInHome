using Microsoft.AspNetCore.Mvc;
using ZeyadInHome.Data;
using ZeyadInHome.Models;

namespace ZeyadInHome.Controllers
{
    public class ProductController : Controller
    {

        public ProjectDbContext Db = new ProjectDbContext();
        public IActionResult Index()
        {
            var All_Products = Db.products.ToList();
            return View(All_Products);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            Db.products.Add(product);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Delete(int id_input)
        {
            var product = Db.products.Where(product_id => product_id.Id == id_input).FirstOrDefault();
            Db.products.Remove(product);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]

        public IActionResult Details(Product product, int id_input)
        {
            var product_data = Db.products.Where(product => product.Id == id_input).FirstOrDefault();
            return View(product_data);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {

            var new_data = Db.products.Where(product => product.Id == Id).FirstOrDefault();
            if (new_data == null)
            {
                return NotFound();
            }
            return View(new_data);
        }


        [HttpPost]
        public IActionResult Edit( int Id, Product product)
        {
            try
            {
                var new_data = Db.products.Where(product => product.Id == Id).FirstOrDefault();
                if (new_data == null)
                {
                    return NotFound();
                }
                new_data.Name = product.Name;
                new_data.Description = product.Description;
                new_data.Price = product.Price;
                new_data.StockQuantity = product.StockQuantity;
                new_data.Category = product.Category;
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}
