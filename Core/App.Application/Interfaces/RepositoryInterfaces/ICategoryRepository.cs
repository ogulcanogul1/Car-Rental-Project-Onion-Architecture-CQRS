﻿using App.Application.Dtos;
using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces.RepositoryInterfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public IQueryable<GroupByCategoryNameBlogCount> GetGroupByCategoryNameBlogCount();
    }
}
