using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MichelleReyesP1.Data;
using MichelleReyesP1.Models;

namespace MichelleReyesP1.Controllers
{
    public class PlanDeRecompensaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanDeRecompensaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlanDeRecompensa
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlanDeRecompensas.ToListAsync());
        }

        // GET: PlanDeRecompensa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanDeRecompensa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,fecha_de_inicio,nombre,puntosAcumulados")] PlanDeRecompensas planDeRecompensas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planDeRecompensas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }
            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,fecha_de_inicio,nombre,puntosAcumulados")] PlanDeRecompensas planDeRecompensas)
        {
            if (id != planDeRecompensas.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planDeRecompensas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanDeRecompensasExists(planDeRecompensas.id))
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
            return View(planDeRecompensas);
        }

        // GET: PlanDeRecompensa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planDeRecompensas = await _context.PlanDeRecompensas
                .FirstOrDefaultAsync(m => m.id == id);
            if (planDeRecompensas == null)
            {
                return NotFound();
            }

            return View(planDeRecompensas);
        }

        // POST: PlanDeRecompensa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planDeRecompensas = await _context.PlanDeRecompensas.FindAsync(id);
            if (planDeRecompensas != null)
            {
                _context.PlanDeRecompensas.Remove(planDeRecompensas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanDeRecompensasExists(int id)
        {
            return _context.PlanDeRecompensas.Any(e => e.id == id);
        }
    }
}
