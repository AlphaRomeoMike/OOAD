namespace OOAD
{
  public class Vehicle
  {
    public string number { get; set; }
    public Vehicle(string _number, string engine_name)
    {
      number = _number;
      Engine engine = new(engine_name);
    }

    public void AssignDriver(Driver driver)
    {
      driver.AssignVehicle(this);
      Console.WriteLine("Driver assigned");
    }

    public void InstallTyres(Tyre tyre)
    {
      Console.WriteLine($"The tyre is {tyre.name}");
    }
  }
}