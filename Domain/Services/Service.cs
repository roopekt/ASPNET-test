namespace Task1.Domain.Services
{
    public class Service
    {
        public string Id;

        public DateTime CreatedAt;

        public Device Device;

        public Service(string id, DateTime createdAt, Device device)
        {
            Id = id;
            CreatedAt = createdAt;
            Device = device;
        }
    }
}
