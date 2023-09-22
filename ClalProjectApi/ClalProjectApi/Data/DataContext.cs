using ClalProjectApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClalProjectApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
    }
}
