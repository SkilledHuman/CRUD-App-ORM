﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_ORM_.Data.Models;

namespace CRUD_ORM_.Data
{
    internal class ProductContext:DbContext
    {
        public ProductContext():base("name = ProductContext")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
