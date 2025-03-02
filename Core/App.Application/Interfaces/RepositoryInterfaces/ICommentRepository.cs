using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        public Task<Comment> GetCommentWithBlogByBlogIdAsync(int blogId);
    }
}
