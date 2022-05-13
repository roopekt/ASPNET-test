namespace Task1.Domain.Services
{
    public class Device
    {
        public string Imei;

        public string Model;

        public string Brand;

        public Device(string imei, string model, string brand)
        {
            Imei = imei;
            Model = model;
            Brand = brand;
        }
    }
}
