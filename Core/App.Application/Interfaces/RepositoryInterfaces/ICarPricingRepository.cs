using App.Domain.Entities.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface ICarPricingRepository : IRepository<CarPricing>
    {
        public IQueryable<CarPricing> GetCarPricingByTime(int id);
    }
}
