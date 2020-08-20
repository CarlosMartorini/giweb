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
    public class TenantService
    {
        private readonly GIWEBContext _context;

        public TenantService(GIWEBContext context)
        {
            _context = context;
        }

        public async Task<List<Tenant>> FindAllAsync()
        {
            return await _context.Tenant.ToListAsync();
        }

        public async Task InsertAsync(Tenant obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Tenant> FindByIdAsync(int id)
        {
            return await _context.Tenant.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Tenant.FindAsync(id);
                _context.Tenant.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales");
            }
        }

        public async Task UpdateAsync(Tenant obj)
        {
            bool hasAny = await _context.Tenant.AnyAsync(x => x.Id == obj.Id);
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

