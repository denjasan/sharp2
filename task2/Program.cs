Plane plane = new("Airbus", 100000000, 857.2, 2010, 10000, 125);
Car car = new("Tractor Belarus", 10000000, 60, 2005);
Ship ship = new("Moskva", 46000000, 77, 2009, "Novorossiysk", 52);

plane.Print();
Console.WriteLine();
car.Print();
Console.WriteLine();
ship.Print();

internal class Vehicle
{
    protected string _name;
    protected double _price;
    protected double _speed;
    protected int _year;

    public Vehicle(string name, double price, double speed, int year)
    {
        _name = name;
        _price = price;
        _speed = speed;
        _year = year;
    }
}

internal class Plane : Vehicle
{
    private double _height;
    private int _quantity;

    public Plane(string name, double price, double speed, int year, double height, int quantity) : base(name, price,
        speed, year)
    {
        _height = height;
        _quantity = quantity;
    }

    public void Print()
    {
        Console.WriteLine("Plane");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Speed: {_speed}");
        Console.WriteLine($"Year: {_year}");
        Console.WriteLine($"Height: {_height}");
        Console.WriteLine($"Quantity of passengers: {_quantity}");
        
    }
}

internal class Car : Vehicle
{
    public Car(string name, double price, double speed, int year) : base(name, price, speed, year){}
    public void Print()
    {
        Console.WriteLine("Car");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Speed: {_speed}");
        Console.WriteLine($"Year: {_year}");
        
    }
    
}

internal class Ship : Vehicle
{
    private string _port;
    private int _quantity;

    public Ship(string name, double price, double speed, int year, string port, int quantity) : base(name, price, speed,
        year)
    {
        _port = port;
        _quantity = quantity;
    }
    
    public void Print()
    {
        Console.WriteLine("Plane");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Speed: {_speed}");
        Console.WriteLine($"Year: {_year}");
        Console.WriteLine($"Port: {_port}");
        Console.WriteLine($"Quantity of passengers: {_quantity}");
        
    }
}
