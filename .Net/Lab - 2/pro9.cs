using System;

class Furniture
{
    protected string material;
    protected double price;

    public void GetFurnitureData()
    {
        Console.Write("Enter Material: ");
        material = Console.ReadLine();

        Console.Write("Enter Price: ");
        price = Convert.ToDouble(Console.ReadLine());
    }
}

class Table : Furniture
{
    private double height;
    private double surface_area;

    public void GetTableData()
    {
        Console.Write("Enter Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Surface Area: ");
        surface_area = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayTableDetails()
    {
        Console.WriteLine("\n--- Table Details ---");
        Console.WriteLine("Material: " + material);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Surface Area: " + surface_area);
    }

    static void Main()
    {
        Table t = new Table();
        t.GetFurnitureData();
        t.GetTableData();
        t.DisplayTableDetails();
    }
}
