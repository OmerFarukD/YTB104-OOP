namespace Inheritance;

    internal class Truck: Vehicle
    {
    public double Capacity;


    public override string ToString()
    {
        return $"Model : {Model}, Marka : {Brand}, Hız: {Speed}, Vites: {TransmissionType}, Renk:{Color}" +
            $", Yakıt Tipi: {FuelType}, Yük Kapasitesi: {Capacity}";
    }
}
