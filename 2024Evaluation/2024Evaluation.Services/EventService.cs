using _2024Evaluation.DAL.Contracts;
using _2024Evaluation.Models;
using _2024Evaluation.Services.Contracts;
using _2024Evaluation.Services.Contracts.DTO.Down;
using _2024Evaluation.Services.Contracts.DTO.Up;
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

        public async Task<EventDownDetailedDTO> SaveProfile(EventUpDetailedDTO eventDTO)
        {
            try
            {
                var newEvent = new Event
                {
                    Title = eventDTO.Title,
                    Description = eventDTO.Description,
                    Date = eventDTO.Date,
                    Time = eventDTO.Time,
                    Location = eventDTO.Location
                };

                await _eventRepository.SaveEvent(newEvent);

                return new EventDownDetailedDTO
                {
                    Id = newEvent.Id,
                    Title = newEvent.Title,
                    Description = newEvent.Description,
                    Date = newEvent.Date,
                    Time = newEvent.Time,
                    Location = newEvent.Location
                };
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                throw new Exception("Error saving event", ex);
            }
        }

    }
}
