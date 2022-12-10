using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace concilig.Data
{
    public class Teste : IdentityDbContext
    {
        public Teste(DbContextOptions<Teste> options)
            : base(options)
        {
        }
    }
}
