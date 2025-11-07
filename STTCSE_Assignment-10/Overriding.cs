using System;

public class Vehicle
{
    protected int speed;
    protected int fuel;

    public Vehicle(int s, int f)
    {
        speed = s;
        fuel = f;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Vehicle Speed: " + speed);
        Console.WriteLine("Vehicle Fuel: " + fuel);
    }

    public virtual void Drive()
    {
        fuel -= 5;
        Console.WriteLine("Vehicle is moving...");
    }
}

public class Car : Vehicle
{
    private int passengers;

    public Car(int s, int f, int p) : base(s, f)
    {
        passengers = p;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Car Passenger count: " + passengers);
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Car is moving with passenger");
    }
}

public class Truck : Vehicle
{
    private int cargoWeight;

    public Truck(int s, int f, int c) : base(s, f)
    {
        cargoWeight = c;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Cargo weight: " + cargoWeight);
    }

    public override void Drive()
    {
        fuel -= 10;
        Console.WriteLine("Truck is moving with cargo");
    }
}

public class Overriding
{
    public static void Main(string[] args)
    {
        Vehicle[] vehicles = {
            new Vehicle(100, 50),
            new Car(120, 60, 4),
            new Truck(80, 70, 1000)
        };

        for (int i = 0; i < 3; i++)
        {
            vehicles[i].ShowInfo();
            vehicles[i].Drive();
            Console.WriteLine();
        }
    }
}