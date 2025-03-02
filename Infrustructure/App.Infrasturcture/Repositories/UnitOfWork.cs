using App.Application.Interfaces;
using App.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RentCarContext _context;
        public UnitOfWork(RentCarContext context)
        {
            _context = context;
        }
        public async ValueTask SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
