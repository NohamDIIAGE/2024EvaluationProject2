using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2024Evaluation.DAL.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DbContextEntity _dbContext;

        public EventRepository(DbContextEntity dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Event>> GetAllEvents()
        {
            return await _dbContext.Events.ToListAsync();
        }
    }
}
