namespace MockingTutorial.Exceptions
{
    public class NoAvailableRoomsException:Exception
    {
        public NoAvailableRoomsException(int beds) : base($"No available rooms with {beds} beds.") { }
    }
}
