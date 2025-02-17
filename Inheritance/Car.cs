

namespace Inheritance;

internal class Car : Vehicle
{
  
    public byte DoorNumber;

    public override string ToString()
    {
        return $"Model : {Model}, Marka : {Brand}, Hız: {Speed}, Vites: {TransmissionType}, Renk:{Color}" +
            $", Yakıt Tipi: {FuelType}, Kapı Sayısı : {DoorNumber}";
    }
}
