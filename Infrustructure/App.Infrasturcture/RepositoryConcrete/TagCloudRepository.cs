using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Domain.Entities;
using App.Persistence.Context;
using App.Persistence.Repositories;

namespace App.Persistence.RepositoryConcrete
{
    public class TagCloudRepository : Repository<TagCloud>, ITagCloudRepository
    {
        private readonly RentCarContext _context;
        public TagCloudRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public IQueryable<TagCloud> GetTagCloudByBlogId(int BlogId) => _context.TagClouds.Where(x => x.BlogId == BlogId);

    }
}
