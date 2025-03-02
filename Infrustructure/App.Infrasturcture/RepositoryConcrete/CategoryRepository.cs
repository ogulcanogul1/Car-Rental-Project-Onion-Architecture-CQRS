using App.Application.Dtos;
using App.Application.Interfaces;
using App.Application.Interfaces.RepositoryInterfaces;
using App.Domain.Entities;
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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly RentCarContext _context;
        public CategoryRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }
        public IQueryable<GroupByCategoryNameBlogCount> GetGroupByCategoryNameBlogCount()
        {
            return _context.Blogs
            .GroupBy(b => new { b.CategoryId, b.Category.Name })
            .Select(group => new GroupByCategoryNameBlogCount
            {
                CategoryId = group.Key.CategoryId,
                CategoryName = group.Key.Name,
                BlogCount = group.Count()
            });

        }
    }
}
