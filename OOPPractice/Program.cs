using OOPPractice;

try
{
    Car myCar = new Car();
    myCar.Model = "M201";
    myCar.Type = "Truck";
    myCar.Color = "Black";
    myCar.LicenseNo = "YGN-001";
    myCar.GearNo = "D";
    myCar.StartEngine();
    myCar.Drive();
    myCar.PlayHorn(3);
    myCar.ShowInfo();
    myCar.StopEngine();

    Console.WriteLine("Inheritance demo");
    TruckCar tc = new TruckCar();
    tc.LicenseNo = "YGN-800";
    tc.Color = "red";
    tc.Type = "Truck";
    tc.GearNo = "D";
    tc.MaximumLoadInTon = 300;
    tc.ShowInfo();
    tc.LoadMaterial(100);
    tc.StartEngine();
    tc.PlayHorn(1);
    tc.Drive();
    tc.StopEngine();

    Console.WriteLine("Polymorphism");
    TruckCar homeTruck = new TruckCar()
    {
        Type = "truck",
        LicenseNo = "MDY-999",
        MaximumLoadInTon = 1000,
        NumberOfWheel = 6,
        Color = "red",
        Model = "M29343",
        GearNo = "P",
    };
    homeTruck.LoadMaterial(100);
    homeTruck.LoadMaterial(20, "Generator");
    homeTruck.ShowInfo();

}catch (Exception e)
{
    Console.WriteLine($"Error occur cos of {e.Message}");
}