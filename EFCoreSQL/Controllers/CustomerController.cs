using EFCoreSQL.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreSQL.Controllers
{
    public class CustomerController : Controller
    {
        private AppDbContext _context;
        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult GetAllCustomer()
        {
            var customers = _context.GetAllCustomers.ToList();
            return Ok(customers);
        }
    }
}
