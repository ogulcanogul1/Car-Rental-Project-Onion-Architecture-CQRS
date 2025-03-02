namespace App.Application.Interfaces;

public interface IRepository<T> where T : class
{
    IQueryable<T?> GetAll(bool tracking = true);
    ValueTask<T?> GetByIdAsync(int id);
    ValueTask CreateAsync(T entity);
    ValueTask UpdateAsync(T entity);
    ValueTask DeleteAsync(int id);
    ValueTask SaveChangesAsync();
}
