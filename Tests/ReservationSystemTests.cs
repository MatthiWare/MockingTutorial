using MockingTutorial;
using MockingTutorial.Data;
using MockingTutorial.Exceptions;
using MockingTutorial.Models;
using MockingTutorial.Services;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ReservationSystemTests
    {
        private readonly ReservationSystem reservationSystem;
        private readonly Mock<IBookingService> bookingServiceMock = new();

        public ReservationSystemTests()
        {
            //reservationSystem = new ReservationSystem(
            //    new BookingService(new BookingDbContext()));

            reservationSystem = new ReservationSystem(
               bookingServiceMock.Object);
        }

        [Fact]
        public async Task ReserveAsync_Throws_When_No_Rooms_Available()
        {
            bookingServiceMock
                .Setup(mock => mock.GetRoomsAsync(10))
                .ReturnsAsync(Enumerable.Empty<Room>());

            await Assert.ThrowsAsync<NoAvailableRoomsException>(
                () => reservationSystem.ReserveAsync(10));
        }

        [Fact]
        public async Task ReserveAsync_Reserves_The_Available_Room()
        {
            var reservedRoom = new Room
            {
                Beds = 10,
                IsReserved = true,
                RoomName = "Room 1"
            };

            var emptyRoom = new Room
            {
                Beds = 10,
                IsReserved = false,
                RoomName = "Room 2"
            };

            bookingServiceMock
                .Setup(mock => mock.GetRoomsAsync(10))
                .ReturnsAsync(new[] 
                {
                    reservedRoom,
                    emptyRoom,
                });

            await reservationSystem.ReserveAsync(10);

            bookingServiceMock
                .Verify(mock => mock.ReserveRoomAsync(emptyRoom.RoomId), Times.Once());
        }
    }
}