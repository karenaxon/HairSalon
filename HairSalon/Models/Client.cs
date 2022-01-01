using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    [Required(ErrorMessage= "A name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage= "Please select a hair stylist.")]
    public int EmployeeId { get; set; }
    
    public virtual Employee Employee { get; set; }   
  }
}