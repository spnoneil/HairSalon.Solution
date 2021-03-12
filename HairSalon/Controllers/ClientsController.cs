using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;
    public ClientsController(SalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(client => client.Stylist).ToList();
      return View(model);
    }
  }
}