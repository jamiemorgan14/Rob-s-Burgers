using System.Collections.Generic;
using Robs_Burgers.Models;

namespace Robs_Burgers.Database
{
  public static class Data
  {
    public static List<MenuItem> Menu = new List<MenuItem>()
    {
      new MenuItem(1, "BigMac", "The Best burger", 3.49m),
      new MenuItem(2, "Double Pounder", "The okayest burger", 2.99m),
      new MenuItem(3, "Filet 'o fish", "wtf is this garbage?", .01m)
  };
  }
}
