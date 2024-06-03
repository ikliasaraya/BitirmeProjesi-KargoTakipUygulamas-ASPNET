using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using KargoTakipUygulaması.Data;
using KargoTakipUygulaması.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace KargoTakipUygulaması.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ApplicationDbContext context, UserManager<User> userManager, ILogger<AdminController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            var cargos = await _context.Cargos
                .Include(c => c.Sender)
                .ToListAsync();
            return View(cargos);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }
        // DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }

            cargo.Status = "İptal Edildi"; // Durumu güncelle
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IFormCollection form)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos.FindAsync(id);
            if (cargo == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cargo.RecipientIdentityNumber = form["RecipientIdentityNumber"];
                    cargo.RecipientName = form["RecipientName"];
                    cargo.RecipientSurname = form["RecipientSurname"];
                    cargo.ShipmentDate = DateTime.Parse(form["ShipmentDate"]);
                    cargo.Address = form["Address"];
                    cargo.Status = form["Status"];

                    if (cargo.Status == "Ulaştı")
                    {
                        cargo.DeliveryDate = DateTime.Now;
                    }

                    _context.Update(cargo);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation("Cargo with ID: {Id} updated successfully", cargo.Id);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!CargoExists(cargo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError(ex, "Error updating cargo with ID: {Id}", cargo.Id);
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        _logger.LogError("Model error: {ErrorMessage}", error.ErrorMessage);
                    }
                }
            }
            return View(cargo);
        }

        private bool CargoExists(string id)
        {
            return _context.Cargos.Any(e => e.Id == id);
        }
    }
}
