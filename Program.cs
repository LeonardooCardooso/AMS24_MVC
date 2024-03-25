class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias de Car e Airplane
        Car myCar = new Car("Toyota", 4);
        Airplane myAirplane = new Airplane("Boeing", 60.5);

        // Chamando métodos comuns
        Console.WriteLine($"Marca do carro: {myCar.Brand}");
        Console.WriteLine($"Marca do avião: {myAirplane.Brand}");

        // Acelerando e parando
        myCar.Accelerate();
        myCar.Stop();

        myAirplane.Accelerate();
        myAirplane.Stop();
    }
}