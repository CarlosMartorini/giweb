using GIWEB.Data;
using GIWEB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GIWEB.Services.Exceptions;

namespace GIWEB.Services
{
    public class PropertieService
    {
        private readonly GIWEBContext _context;

        public PropertieService(GIWEBContext context)
        {
            _context = context;
        }

        public async Task<List<Propertie>> FindAllAsync()
        {
            return await _context.Propertie.ToListAsync();
        }

        public async Task InsertAsync(Propertie obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Propertie> FindByIdAsync(int id)
        {
            return await _context.Propertie.Include(obj => obj.Owner).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Propertie.FindAsync(id);
                _context.Propertie.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }

        public async Task UpdateAsync(Propertie obj)
        {
            bool hasAny = await _context.Propertie.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("ID not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
