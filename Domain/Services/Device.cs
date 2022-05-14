namespace Task1.Domain.Services
{
    public class Device
    {
        public string Imei { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public Device(string imei, string model, string brand)
        {
            Imei = imei;
            Model = model;
            Brand = brand;
        }
    }
}
