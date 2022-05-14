namespace Task1.Domain.Services
{
    public class Service
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public Device Device { get; set; }

        public Service(string id, DateTime createdAt, Device device)
        {
            Id = id;
            CreatedAt = createdAt;
            Device = device;
        }
    }
}
