using System;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string CustomerName { get; set; }
    public DateTime Appointments { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}