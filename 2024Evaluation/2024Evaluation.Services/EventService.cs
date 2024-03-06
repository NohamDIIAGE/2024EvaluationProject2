using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.Models;
using _2024Evaluation.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2024Evaluation.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<List<Event>> GetAllEvents()
        {
            return await _eventRepository.GetAllEvents();
        }
    }
}
