using App.Application.Interfaces;
using App.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RentCarContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public Repository(RentCarContext context, IUnitOfWork unitOfWork)
        {
            _dbSet = context.Set<T>();
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public async ValueTask CreateAsync(T entity) 
        {

            await _dbSet.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        } 
        public async ValueTask DeleteAsync(int id) {

            _dbSet.Remove((await _dbSet.FindAsync(id))!);
            await _unitOfWork.SaveChangesAsync();
        } 

        public IQueryable<T?> GetAll(bool tracking = true)
        {
            IQueryable<T> query = _dbSet.AsQueryable();

            if (!tracking)
                query.AsNoTracking();
            return query;   
        }

        public async ValueTask<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async ValueTask SaveChangesAsync()=>await _context.SaveChangesAsync();


        public async ValueTask UpdateAsync(T entity) {

            _dbSet.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        } 
    }

}
