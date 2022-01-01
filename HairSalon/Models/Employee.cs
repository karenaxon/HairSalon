using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  public class Employee
  {
    public Employee()
    {
      this.Clients = new HashSet<Client>();
    }

    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "A name is required.")]
    public string Name { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

  }
}