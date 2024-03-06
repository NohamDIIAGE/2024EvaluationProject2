using _2024Evaluation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024Evaluation.DAL.Contracts
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllEvents();

        Task DeleteEvent(Event myEvent);

        Task<Event> GetEventById(int idEvent);

    }
}
