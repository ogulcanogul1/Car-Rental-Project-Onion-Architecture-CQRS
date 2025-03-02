using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface ITagCloudRepository : IRepository<TagCloud>
    {
        public IQueryable<TagCloud> GetTagCloudByBlogId(int BlogId);
    }
}
