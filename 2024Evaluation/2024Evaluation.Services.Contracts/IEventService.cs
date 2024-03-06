using _2024Evaluation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2024Evaluation.Services.Contracts
{
    public interface IEventService
    {
        Task<List<Event>> GetAllEvents();
    }
}
