using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.Models;
using _2024Evaluation.Services.Contracts;
using _2024Evaluation.Services.Contracts.DTO.Down;
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

        public async Task DeleteEvent(int idEvent)
        {
            var myEvent = this._eventRepository.GetEventById(idEvent).Result;

            await this._eventRepository.DeleteEvent(myEvent);
        }

        public async Task<EventDownDetailedDTO> GetEventById(int idEvent)
        {
            var myEvent = await this._eventRepository.GetEventById(idEvent);

            return new EventDownDetailedDTO()
            {
                Id = myEvent.Id,
                Title = myEvent.Title,
                Description = myEvent.Description,
                Date = myEvent.Date,
                Time = myEvent.Time,
                Location = myEvent.Location,
            };
        }
    }
}
