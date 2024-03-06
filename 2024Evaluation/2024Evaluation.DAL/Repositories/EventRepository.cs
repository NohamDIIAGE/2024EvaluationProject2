using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024Evaluation.DAL.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DbContextEntity _dbContext;

        public EventRepository(DbContextEntity dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteEvent(Event myEvent)
        {
            _dbContext.Events.Remove(myEvent);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<Event>> GetAllEvents()
        {
            return await _dbContext.Events.ToListAsync();
        }

        public async Task<Event> GetEventById(int idEvent)
        {
            return await this._dbContext.Events.SingleAsync(p => p.Id == idEvent);
        }
    }
}
