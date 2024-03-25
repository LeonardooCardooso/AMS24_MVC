using System;

// Classe abstrata Vehicle
abstract class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    // Método abstrato para acelerar
    public abstract void Accelerate();

    // Método abstrato para parar
    public abstract void Stop();
}