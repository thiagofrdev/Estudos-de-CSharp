using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaWebApi.Models;

namespace MinhaWebApi.Context
{
    public class MinhaWebApiDbContext : DbContext
    {
        public MinhaWebApiDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}