namespace LinQPratice;

public class Truck : Vehicle
{
    public double loadCapacity;
    public double towingCapacity;
    
    public void inputInformation()
    {
        base.inputInformation();
        Console.WriteLine("Enter load capacity: ");
        loadCapacity = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter towing capacity: ");
        towingCapacity = Convert.ToDouble(Console.ReadLine());
    }
}