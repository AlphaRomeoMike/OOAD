namespace OOAD
{
  class Program
  {
    public static void Main(string[] args)
    {
      Vehicle vehicle = new("AB-1223", "CHASSIS-122");
      Tyre tyre = new("Panther");
      Driver driver = new("Moti");

      vehicle.AssignDriver(driver);
      vehicle.InstallTyres(tyre);
    }
  }
}