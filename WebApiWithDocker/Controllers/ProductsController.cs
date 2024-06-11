using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithDocker.Data;
using WebApiWithDocker.Models;

namespace WebApiWithDocker.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly OnlineShopDbContext _context;

        public ProductsController(OnlineShopDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
