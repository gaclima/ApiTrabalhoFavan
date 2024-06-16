using Microsoft.EntityFrameworkCore;
using ApiLoja.models;

namespace ApiLoja.Data;

public class ApiLojaContext : DbContext
{
    public ApiLojaContext(DbContextOptions<ApiLojaContext> options) : base(options)
    {}

    public DbSet<Produto> Produtos {get; set;} = null!;
    
}

