using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Domain.Entities.Cars;
using App.Persistence.Context;
using App.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.RepositoryConcrete
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        private readonly RentCarContext _context;
        public CarRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public async Task<Car> GetCarWithBrandAsync(int id)
        {
            return await GetAll().Where(x => x.Id == id).Include(x => x.Brand).FirstOrDefaultAsync();

        }
        public IQueryable<Car> GetCarsWithBrandAsync(bool tracking) => GetAll(tracking).Include(x => x.Brand).AsQueryable();


        public IQueryable<Car> GetDynamicCarWithBrands(bool isFirst,int count) => isFirst ? GetAll().Include(x => x.Brand).OrderBy(x => x.Id).Take(count) : GetAll().Include(x => x.Brand).OrderByDescending(x => x.Id).Take(count);


        public IQueryable<Car> GetCarsWithBrandPricing() => GetAll().Include(x => x.Brand).Include(x => x.CarPricings).ThenInclude(x => x.RentType).AsQueryable();

    }
}
