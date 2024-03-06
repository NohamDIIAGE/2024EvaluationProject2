using _2024Evaluation.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Evaluation.Azure.Startup
{
    public class DbContextEntityFactory : IDesignTimeDbContextFactory<DbContextEntity>
    {
        public DbContextEntity CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContextEntity>();

            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("EvaluationConnectionString"));

            return new DbContextEntity(optionsBuilder.Options);
        }
    }
}
