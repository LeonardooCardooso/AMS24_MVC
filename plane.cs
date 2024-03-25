
// Classe concreta Airplane (herda de Vehicle)
class Airplane : Vehicle
{
    public double Wingspan { get; set; }

    public Airplane(string brand, double wingspan) : base(brand)
    {
        Wingspan = wingspan;
    }

    public override void Accelerate()
    {
        Console.WriteLine($"Avião {Brand} ganhando velocidade com envergadura de {Wingspan} metros...");
    }

    public override void Stop()
    {
        Console.WriteLine($"Avião {Brand} reduzindo a velocidade...");
    }
}