// Classe concreta Car (herda de Vehicle)
class Car : Vehicle
{
    public int NumberOfWheels { get; set; }

    public Car(string brand, int wheels) : base(brand)
    {
        NumberOfWheels = wheels;
    }

    public override void Accelerate()
    {
        Console.WriteLine($"Carro {Brand} acelerando com {NumberOfWheels} rodas...");
    }

    public override void Stop()
    {
        Console.WriteLine($"Carro {Brand} parando...");
    }
}
