using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using open_street_maps.Models;

namespace open_street_maps.Controllers;

public class HomeController : Controller
{
    private readonly Context db;
    public HomeController(Context x)
    {
        db = x;
    }

    
    public IActionResult Index()
    {

        ViewBag.B =db.Tbl_Addresses.ToList();
        return View();
    }

     public IActionResult add(Tbl_Address X )
    {
       db.Tbl_Addresses.Add(X);
       db.SaveChanges();
       return RedirectToAction("index");
    }


}
