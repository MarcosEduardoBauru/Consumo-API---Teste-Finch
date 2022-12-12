using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using concilig.Models;

    public class DefaultConnection : DbContext
    {
        public DefaultConnection (DbContextOptions<DefaultConnection> options)
            : base(options)
        {
        }

    }
