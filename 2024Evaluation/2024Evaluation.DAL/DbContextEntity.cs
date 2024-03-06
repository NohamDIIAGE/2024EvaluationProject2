using _2024Evaluation.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace _2024Evaluation.DAL
{
    public class DbContextEntity : DbContext
    {
        public DbContextEntity(DbContextOptions<DbContextEntity> options) : base(options)
        {
        }

    }
}
