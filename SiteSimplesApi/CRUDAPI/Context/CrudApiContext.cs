using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Context
{
    public class CrudApiContext : DbContext
    {
        public CrudApiContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}