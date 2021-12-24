using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
  public class EmployeesController : Controller
  {
    private readonly HairSalonContext _db;

    public EmployeesController(HairSalonContext db)
    {
      _db = db;
    }
  }
}