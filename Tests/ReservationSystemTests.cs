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

        public ReservationSystemTests()
        {
            reservationSystem = new ReservationSystem(
                new BookingService(new BookingDbContext()));
        }

        [Fact]
        public async Task ReserveAsync_Throws_When_No_Rooms_Available()
        {
            
        }

        [Fact]
        public async Task ReserveAsync_Reserves_The_Available_Room()
        {
        }
    }
}