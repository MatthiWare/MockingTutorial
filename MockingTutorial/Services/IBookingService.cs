using MockingTutorial.Models;

namespace MockingTutorial.Services
{
    public interface IBookingService
    {
        public Task<IEnumerable<Room>> GetRoomsAsync(int beds);
        public Task ReserveRoomAsync(Guid roomId);
    }
}
