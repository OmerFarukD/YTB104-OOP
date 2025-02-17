
using Inheritance;

Console.WriteLine("Hello, World!");

Truck truck = new Truck()
{
    Brand = "Volvo",
    Model="FH540",
    Capacity=10,
    Color = "Ekru",
    FuelType = "Benzin",
    Speed = 150,
    TransmissionType = "Manuel"
};

Car car = new Car()
{
    Brand = "Volvo",
    Model = "s60",
    Color = "Siayh",
    FuelType = "Elektrikli",
    Speed = 240,
    TransmissionType = "Otomatik",
    DoorNumber = 4
};

Motorcycle motorcycle = new Motorcycle()
{
    Brand = "Yamaha",
    Model = "MT07ABS",
    Color = "Gece Mavisi",
    FuelType = "Benzin",
    Speed = 280,
    TransmissionType = "Yarı Otomatik",
    HasStand = true
};

Console.WriteLine(car);
Console.WriteLine(truck);
Console.WriteLine(motorcycle);