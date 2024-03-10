namespace LinQPratice;

public class Vehicle
{   
    public string model;
    public string brand;
    public int year;
    public double price;
    
    public void inputInformation()
    {
        Console.WriteLine("Enter model: ");
        model = Console.ReadLine();
        Console.WriteLine("Enter brand: ");
        brand = Console.ReadLine();
        Console.WriteLine("Enter year: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter price: ");
        price = Convert.ToDouble(Console.ReadLine());
    }
    
    public void displayInformation()
    {
        Console.WriteLine(this);
    }
    
}