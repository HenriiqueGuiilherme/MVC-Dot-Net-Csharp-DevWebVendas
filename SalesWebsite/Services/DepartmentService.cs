using SalesWebsite.Data;
using SalesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebsite.Services
{
    public class DepartmentService
    {
        private readonly SalesWebsiteContext _context;

        public DepartmentService(SalesWebsiteContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return  await _context.Department.ToListAsync();
        }
    }
}
