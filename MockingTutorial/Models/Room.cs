namespace MockingTutorial.Models
{
    public sealed class Room
    {
        public Guid RoomId { get; set; } = Guid.NewGuid();
        public string RoomName { get; set; }
        public int Beds { get; set; }
        public bool IsReserved { get; set; } = false;
    }
}
