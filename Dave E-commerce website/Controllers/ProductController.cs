using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Dave_E_commerce_website.Data;
using Dave_E_commerce_website.Models;
using Dave_E_commerce_website.ViewModel;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using Microsoft.AspNetCore.Hosting;

namespace Dave_E_commerce_website.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;      

        public ProductController(IWebHostEnvironment webHostEnvironment)
        {
            _context = new ApplicationDbContext();
            _webHostEnvironment = webHostEnvironment;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult Index()
        {
            var products = _context.product.Include(p => p.Category).ToList();
            return View(products);
        }

        public IActionResult Indexe()
        {
            return View();
        }


        public IActionResult NewProduct()
        {
            var category = _context.category.ToList();
            var viewModel = new NewProductViewModel
            {
                Product = new Product(),
                Category = category
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewProductViewModel
                {
                    Product = product,
                    Category = _context.category.ToList()
                };
                return View("NewProduct", viewModel);
            }

  
            {
                string uniqueFileName = null;
                if (product.Picture != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + product.Picture.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    product.Picture.CopyTo(new FileStream(filePath, FileMode.Create));
                    product.PhotoPath = "/Images/" + uniqueFileName;
                }

                
                _context.product.Add(product);
                _context.SaveChanges();


                return RedirectToAction("CategoryPage", new { categoryId = product.CategoryId });
            }
        }

        public IActionResult CategoryPage(int categoryId)
        {
            var productsInCategory = _context.product.Where(p => p.CategoryId == categoryId).ToList(); 

            if (productsInCategory == null)
            {
                return Content("nothing here mate");
            }

            return View(productsInCategory);
        }


    }

}

        
           



//Name = model.Product.Name,
//category = model.Product.category,
//ProductDescription = model.Product.ProductDescription,
//Color = model.Product.Color,
//AvailabilityInStock = model.Product.AvailabilityInStock,
//picture = uniqueFileName