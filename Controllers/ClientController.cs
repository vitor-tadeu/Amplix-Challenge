using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Company.DataContext;
using Company.Models;
using System;

namespace Company.Controllers
{
    public class ClientController : Controller
    {
        private const string fields = "id, company_name, fantasy_name, cnpj, foundation_date, manager, email, phone, website, cep, address, address_number, complement, neighborhood, city, state";
        private readonly Context _context;

        public ClientController(Context context)
        {
            _context = context;
        }

        // GET: Client
        public async Task<IActionResult> Index(string searchString)
        {
            var name = from m in _context.Clients select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                name = name.Where(s => s.fantasy_name.Contains(searchString));
            }

            return View(await name.ToListAsync());
        }

        // GET: Client/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Client/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(fields)] Client client)
        {
            if (id != client.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // POST: Client/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.id == id);
        }
    }
}
