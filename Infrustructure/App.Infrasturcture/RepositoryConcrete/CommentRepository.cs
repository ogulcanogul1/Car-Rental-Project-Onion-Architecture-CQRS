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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly RentCarContext _context;
        public CommentRepository(RentCarContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
        }

        public async Task<Comment> GetCommentWithBlogByBlogIdAsync(int blogId) => await _context.Comments.Where(x => x.BlogId == blogId).FirstOrDefaultAsync();

    }
}
