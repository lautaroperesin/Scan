﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScanService.DataContext;
using ScanServices.Models;

namespace ScanBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonacionesController : ControllerBase
    {
        private readonly ScanContext _context;

        public DonacionesController(ScanContext context)
        {
            _context = context;
        }

        // GET: api/Donaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donacion>>> GetDonaciones()
        {
            return await _context.Donaciones.ToListAsync();
        }

        // GET: api/Donaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donacion>> GetDonacion(int id)
        {
            var donacion = await _context.Donaciones.FindAsync(id);

            if (donacion == null)
            {
                return NotFound();
            }

            return donacion;
        }

        // PUT: api/Donaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonacion(int id, Donacion donacion)
        {
            if (id != donacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(donacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Donaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Donacion>> PostDonacion(Donacion donacion)
        {
            _context.Donaciones.Add(donacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonacion", new { id = donacion.Id }, donacion);
        }

        // DELETE: api/Donaciones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonacion(int id)
        {
            var donacion = await _context.Donaciones.FindAsync(id);
            if (donacion == null)
            {
                return NotFound();
            }

            _context.Donaciones.Remove(donacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonacionExists(int id)
        {
            return _context.Donaciones.Any(e => e.Id == id);
        }
    }
}
