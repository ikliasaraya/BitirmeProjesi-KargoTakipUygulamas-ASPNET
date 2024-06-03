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
    [Authorize]
    public class CargoController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<CargoController> _logger;

        public CargoController(ApplicationDbContext context, UserManager<User> userManager, ILogger<CargoController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: Cargo
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                _logger.LogError("User ID is null.");
                return Unauthorized();
            }

            var cargos = await _context.Cargos
                .Include(c => c.Sender)
                .Where(c => c.SenderId == userId)
                .ToListAsync();
            return View(cargos);
        }

        // GET: Cargo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos
                .Include(c => c.Sender)
                .FirstOrDefaultAsync(m => m.Id == id);
            var userId = _userManager.GetUserId(User);
            if (cargo == null || cargo.SenderId != userId)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // GET: Cargo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cargo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                if (userId == null)
                {
                    _logger.LogError("User ID is null.");
                    return Unauthorized();
                }

                var shipmentDate = DateTime.Now;
                if (form["ShipmentType"] == "İleri Zamanlı")
                {
                    shipmentDate = DateTime.Parse(form["ShipmentDate"]);
                }

                var cargo = new Cargo
                {
                    Id = Guid.NewGuid().ToString(),
                    SenderId = userId,
                    RecipientIdentityNumber = form["RecipientIdentityNumber"],
                    RecipientName = form["RecipientName"],
                    RecipientSurname = form["RecipientSurname"],
                    Status = "Onay Bekliyor", // Default status
                    ShipmentDate = shipmentDate,
                    Address = form["Address"]
                };

                _context.Add(cargo);
                await _context.SaveChangesAsync();
                _logger.LogInformation("New cargo created with ID: {Id}", cargo.Id);
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
            return View();
        }

        // GET: Cargo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos.FindAsync(id);
            var userId = _userManager.GetUserId(User);
            if (cargo == null || cargo.SenderId != userId)
            {
                return NotFound();
            }
            return View(cargo);
        }

        // POST: Cargo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IFormCollection form)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await _context.Cargos.FindAsync(id);
            var userId = _userManager.GetUserId(User);
            if (cargo == null || cargo.SenderId != userId)
            {
                return Unauthorized();
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

                    // Status alanının var olan değerini koruyun
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

        // POST: Cargo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cargo = await _context.Cargos.FindAsync(id);
            var userId = _userManager.GetUserId(User);
            if (cargo == null || cargo.SenderId != userId)
            {
                return NotFound();
            }

            _context.Cargos.Remove(cargo);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Cargo with ID: {Id} deleted successfully", cargo.Id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Cargo/History
        public async Task<IActionResult> History()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                _logger.LogError("User ID is null.");
                return Unauthorized();
            }

            var userIdentityNumber = _context.Users
                .Where(u => u.Id == userId)
                .Select(u => u.IdentityNumber)
                .FirstOrDefault();

            var sentCargos = await _context.Cargos
                .Include(c => c.Sender)
                .Where(c => c.SenderId == userId)
                .ToListAsync();

            var receivedCargos = await _context.Cargos
                .Where(c => c.RecipientIdentityNumber == userIdentityNumber)
                .ToListAsync();

            var viewModel = new CargoHistoryViewModel
            {
                SentCargos = sentCargos,
                ReceivedCargos = receivedCargos
            };

            return View(viewModel);
        }

        private bool CargoExists(string id)
        {
            return _context.Cargos.Any(e => e.Id == id);
        }
    }
}
