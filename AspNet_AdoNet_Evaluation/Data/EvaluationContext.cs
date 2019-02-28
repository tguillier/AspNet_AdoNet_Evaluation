using AspNet_AdoNet_Evaluation.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_AdoNet_Evaluation.Data
{
    public class EvaluationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public EvaluationContext(DbContextOptions<EvaluationContext> options) : base(options)
        {
        }
    }
}
