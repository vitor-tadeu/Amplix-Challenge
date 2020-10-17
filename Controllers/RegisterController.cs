using Company.DataContext;
using Company.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Company.Controllers
{
    public class RegisterController : Controller
    {
        private const string fields = "id, company_name, fantasy_name, cnpj, foundation_date, manager, email, phone, website, cep, address, address_number, complement, neighborhood, city, state";
        private readonly Context _context;

        public RegisterController(Context context)
        {
            _context = context;
        }

        // GET: Register
        public IActionResult Index()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind(fields)] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
            }
            return View(client);
        }
    }
}
