using _2024Evaluation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2024Evaluation.DAL.Contracts
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllEvents();
    }
}
