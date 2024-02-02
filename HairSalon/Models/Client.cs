using System;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    [Display(Name = "Customer Name")]
    public string CustomerName { get; set; }
    [Display(Name = "Next Appointment Date")]
    public DateTime Appointments { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}