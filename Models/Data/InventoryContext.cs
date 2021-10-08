﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDemo.Models.Data
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options)
        { 
        
        }

        public virtual DbSet<Unit> Units { get; set; }
    }
}
