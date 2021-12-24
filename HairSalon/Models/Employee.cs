using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Employee
  {
    
    public Employee()
    {
      this.Clients = new HashSet<Client>();
    }

    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }

  }
}