namespace Robs_Burgers.Models
{
  public class MenuItem
  {
    public int Number { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public MenuItem(int number, string name, string description, decimal price)
    {
      Number = number;
      Name = name;
      Description = description;
      Price = price;
    }
  }
}