using System;

class House
{
    public int YearBuilt { get; set; }
    public double Size { get; set; }

    public House(int yearBuilt, double size)
    {
        YearBuilt = yearBuilt;
        Size = size;
    }

    private int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - YearBuilt;
    }

    public bool CanBeSold()
    {
        return HowOld() > 15;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== House Details Input ===");
        Console.Write("Enter the year the house was built: ");
        int yearBuilt = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of the house: ");
        double size = Convert.ToDouble(Console.ReadLine());

        House house = new House(yearBuilt, size);

        Console.WriteLine("\n--- House Information ---");
        Console.WriteLine($"Year Built: {house.YearBuilt}");
        Console.WriteLine($"Size: {house.Size} sq. units");
        Console.WriteLine($"Can be sold: {house.CanBeSold()}");
    }
}