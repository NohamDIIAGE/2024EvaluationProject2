using _2024Evaluation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using _2024Evaluation.Services.Contracts.DTO.Down;
using _2024Evaluation.Services.Contracts.DTO.Up;

namespace _2024Evaluation.Services.Contracts
{
    public interface IEventService
    {
        Task<List<Event>> GetAllEvents();

        Task DeleteEvent(int idEvent);

        Task<EventDownDetailedDTO> GetEventById(int idEvent);

        Task<EventDownDetailedDTO> SaveProfile(EventUpDetailedDTO profileDTO);

    }
}
