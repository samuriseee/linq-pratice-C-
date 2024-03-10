namespace LinQPratice;

public class Car : Vehicle
{
    public int numberOfSeats;
    public string type;
    
    public void inputInformation()
    {
        base.inputInformation();
        Console.WriteLine("Enter number of seats: ");
        numberOfSeats = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter type: ");
        type = Console.ReadLine();
    }
    
}