﻿using Phase3Section2._20.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phase3Section2._32.Models
{
    public class GenericDBContext : DbContext
    {
        public GenericDBContext()
           : base("School1Entities")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}

