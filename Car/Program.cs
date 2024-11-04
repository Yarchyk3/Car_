using System;

class Car
{

    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public const string CompanyName = "Car Company";

   
    public Car()
    {
        Name = "Unknown";
        Color = "Unknown";
        Price = 0.0;
    }

     public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

  
    public void Input()
    {
        Console.WriteLine("Enter car name:");
        Name = Console.ReadLine();

        Console.WriteLine("Enter car color:");
        Color = Console.ReadLine();

        Console.WriteLine("Enter car price:");
        Price = Convert.ToDouble(Console.ReadLine());
    }

   
    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}, Price: {Price}, Company: {CompanyName}");
    }

   
    public void ChangePrice(double x)
    {
        Price -= Price * (x / 100);
    }

   
    public void Repaint(string newColor)
    {
        if (Color.ToLower() == "white")
        {
            Color = newColor;
        }
    }

    
    public string PrintInfo()
    {
        return $"Car Info - Name: {Name}, Color: {Color}, Price: {Price}, Company: {CompanyName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Car[] cars = new Car[3];
        for (int i = 0; i < 3; i++)
        {
            cars[i] = new Car();
            cars[i].Input();
        }

       
        Console.WriteLine("\nReducing prices by 10%...\n");
        foreach (var car in cars)
        {
            car.ChangePrice(10);
            car.Print();
        }

        Console.WriteLine("\nEnter a new color to repaint white cars:");
        string newColor = Console.ReadLine();
        foreach (var car in cars)
        {
            car.Repaint(newColor);
            Console.WriteLine(car.PrintInfo());
        }
    }
}
