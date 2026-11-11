using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    public string Welcome(string name,int numTimes=1)
    {
        return HtmlEncoder.Default.Encode(
         $"Hello {name},numTimes is: {numTimes}");
    }

    public string Index(){
        return "This is my default action method...";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
