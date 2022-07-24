namespace MockingTutorial.Exceptions
{
    public class RoomAlreadyReservedException : Exception
    {
        public RoomAlreadyReservedException(Guid roomId) : base($"Room '{roomId}' is already reserved.") { }
    }
}
