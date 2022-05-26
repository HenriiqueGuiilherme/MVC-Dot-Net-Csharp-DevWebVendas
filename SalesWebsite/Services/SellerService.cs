﻿using SalesWebsite.Data;
using SalesWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebsite.Services
{
    public class SellerService
    {
        private readonly SalesWebsiteContext _context;

        public SellerService(SalesWebsiteContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}