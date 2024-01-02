using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dave_E_commerce_website.Data;
using Dave_E_commerce_website.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dave_E_commerce_website.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _context.product.ToList();
        }

        // GET api/Product/
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct (int Id)
        {
            var product = _context.product.SingleOrDefault(c => c.Id == Id);

            if (product == null)
                return NotFound();

            return product;
        }



        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

