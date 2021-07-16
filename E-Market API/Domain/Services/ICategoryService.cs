using E_Market_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market_API.Domain.Services
{
    interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
