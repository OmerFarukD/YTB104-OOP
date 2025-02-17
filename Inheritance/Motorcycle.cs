namespace Inheritance
{
    internal class Motorcycle : Vehicle
    {
        public bool HasStand;

        public override string ToString()
        {
            return $"Model : {Model}, Marka : {Brand}, Hız: {Speed}, Vites: {TransmissionType}, Renk:{Color}" +
                $", Yakıt Tipi: {FuelType}, Ayaklık var mı : {HasStand}";
        }

    }
}
