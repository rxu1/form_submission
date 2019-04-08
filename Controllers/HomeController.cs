using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("user/create")]
    public IActionResult Create(User newUser)
    {
      if(ModelState.IsValid)
        return RedirectToAction("Success", newUser);
      
      else 
        return View("Index");
    }

    [HttpGet("success")]
    public IActionResult Success()
    {
      return View("Success");
    }

  }
}
