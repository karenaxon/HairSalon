using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }  
    
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client =>client.Employee).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.EmployeeId = new SelectList(_db.Employees, "EmployeeId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if(!ModelState.IsValid)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}