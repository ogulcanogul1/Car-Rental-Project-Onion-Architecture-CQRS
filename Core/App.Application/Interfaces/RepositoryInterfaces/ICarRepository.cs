using App.Application.Interfaces;
using App.Domain.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface ICarRepository : IRepository<Car>
    {
        public Task<Car> GetCarWithBrandAsync(int id);
        public IQueryable<Car> GetCarsWithBrandAsync(bool tracking);

        public IQueryable<Car> GetDynamicCarWithBrands(bool isFirst, int count);

        public IQueryable<Car> GetCarsWithBrandPricing();

    }
}
