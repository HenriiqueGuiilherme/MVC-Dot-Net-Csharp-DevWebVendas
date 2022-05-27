using SalesWebsite.Data;
using SalesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebsite.Services
{
    public class DepartmentService
    {
        private readonly SalesWebsiteContext _context;

        public DepartmentService(SalesWebsiteContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.ToList();
        }
    }
}
