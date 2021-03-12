using System.Collections.Generic;

namespace Salon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Speciality { get; set; }

    public string PhoneNumber { get; set; }
    public int HourlyRate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}