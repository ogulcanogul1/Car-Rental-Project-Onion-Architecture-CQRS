using App.Application.Dtos;
using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface IBlogRepository : IRepository<Blog>
    {
        public IQueryable<Blog> GetAllBlogsWithAuthor(bool tracking);
        public IQueryable<Blog> GetDynamicBlogsWithAuthor(bool isFirst, int count);
        public Task<Blog> GetAuthorDetailByBlogIdAsync(int blogId);

    }
}
