using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordsController : Controller
  {
    [HttpGet("/records")] 
    public ActionResult Index()
    {
      List<Records> allRecords = Records.GetAll();
      return View(allRecords);
    }
    }
  }
