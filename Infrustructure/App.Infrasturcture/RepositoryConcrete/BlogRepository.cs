using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Domain.Entities;
using App.Persistence.Context;
using App.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.RepositoryConcrete
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        private readonly RentCarContext _context;
        public BlogRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public IQueryable<Blog> GetAllBlogsWithAuthor(bool tracking)
        {
            return _context.Blogs.OrderByDescending(x => x.Id).AsQueryable().Include(x => x.Author);
        }

        public IQueryable<Blog> GetDynamicBlogsWithAuthor(bool isFirst, int count)
        {
            return isFirst ? _context.Blogs.AsQueryable().Include(x => x.Author).OrderBy(x => x.Id).Take(count) : _context.Blogs.AsQueryable().Include(x => x.Author).OrderByDescending(x => x.Id).Take(count);
        }


        public async Task<Blog> GetAuthorDetailByBlogIdAsync(int blogId) => await _context.Blogs.Where(x=> x.Id == blogId).Include(x => x.Author).FirstOrDefaultAsync();


    }
}
