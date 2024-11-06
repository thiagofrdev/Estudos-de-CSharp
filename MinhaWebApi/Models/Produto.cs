using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaWebApi.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? ProdutoName { get; set;}
        public string? ProdutoDescription { get; set; }
        public double Price { get; set; }
        public float Stock { get; set; }
        public DateTime RegistrationDate { get; set;}
    }
}