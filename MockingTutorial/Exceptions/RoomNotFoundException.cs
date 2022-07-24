namespace MockingTutorial.Exceptions
{
    public class RoomNotFoundException : Exception
    {
        public RoomNotFoundException(Guid roomId) : base($"Room '{roomId}' does not exist.") { }
    }
}
