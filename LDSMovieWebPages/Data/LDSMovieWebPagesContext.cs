﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace LDSMovieWebPages.Models
{
    public class LDSMovieWebPagesContext : DbContext
    {
        public LDSMovieWebPagesContext (DbContextOptions<LDSMovieWebPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
