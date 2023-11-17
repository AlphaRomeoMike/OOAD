namespace OOAD 
{
  public class Driver
  {
    public string name { get; set; }

    public Driver(string _name)
    {
      name = _name;
    }

    public void AssignVehicle(Vehicle vehicle)
    {
      Console.WriteLine("Vehicle assigned");
    }
  }
}