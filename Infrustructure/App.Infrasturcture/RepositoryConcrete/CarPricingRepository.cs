using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Domain.Entities.Cars;
using App.Persistence.Context;
using App.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.RepositoryConcrete
{
    internal class CarPricingRepository : Repository<CarPricing>, ICarPricingRepository
    {
        private readonly RentCarContext _context;
        public CarPricingRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public IQueryable<CarPricing> GetCarPricingByTime(int id)
            => GetAll().Include(x => x.Car).Include(x => x.RentType).Where(x => x.RentTypeId == id).AsQueryable();

    }
}
