using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranslateBot.Data;
using TranslateBot.Models;

namespace TranslateBot.Controllers
{
    public class PhrasesController : Controller
    {
        private readonly LocalDbContext _context;

        public PhrasesController(LocalDbContext context)
        {
            _context = context;
        }

        // GET: Phrases
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Local.ToListAsync());
        }

        // GET: Phrases/Edit/5
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phrase = await _context.Local.FindAsync(id);
            if (phrase == null)
            {
                return NotFound();
            }
            return View(phrase);
        }

        // POST: Phrases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhraseId,src,dst")] Phrase phrase)
        {
            if (id != phrase.PhraseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phrase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhraseExists(phrase.PhraseId))
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
            return View(phrase);
        }

        // GET: Phrases/Delete/5
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phrase = await _context.Local
                .FirstOrDefaultAsync(m => m.PhraseId == id);
            if (phrase == null)
            {
                return NotFound();
            }

            return View(phrase);
        }

        // POST: Phrases/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phrase = await _context.Local.FindAsync(id);
            _context.Local.Remove(phrase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }

        private bool PhraseExists(int id)
        {
            return _context.Local.Any(e => e.PhraseId == id);
        }
    }
}
