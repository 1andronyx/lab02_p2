using System;


class Vehicle
{
    protected double x, y;
    protected double price;
    protected double speed;
    protected int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public virtual void info()
    {
        Console.WriteLine($"Coordinates: ({x}, {y})");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Speed: {speed} km/h");
        Console.WriteLine($"Year: {year}");
    }
}


class Plane : Vehicle
{
    private double altitude;
    private int passengers;

    public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
        : base(x, y, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public override void info()
    {
        base.info();
        Console.WriteLine($"Altitude: {altitude} m");
        Console.WriteLine($"Passengers: {passengers}");
    }
}


class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year)
    {
    }
}


class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public override void info()
    {
        base.info();
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Port: {port}");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Vehicle vehicle = new Vehicle(1.0, 2.0, 2000000, 210, 2014);
        Plane plane = new Plane(3.0, 4.0, 100000000, 800, 2021, 9500, 318);
        Car car = new Car(5.0, 6.0, 35000, 180, 2020);
        Ship ship = new Ship(100.0, 200.0, 100000000, 35, 2015, 5000, "Tel Aviv");


        Console.WriteLine("Vehicle information:");
        vehicle.info();
        Console.WriteLine();

        Console.WriteLine("Plane information:");
        plane.info();
        Console.WriteLine();

        Console.WriteLine("Car information:");
        car.info();
        Console.WriteLine();

        Console.WriteLine("Ship information:");
        ship.info();
        Console.WriteLine();
    }
}
