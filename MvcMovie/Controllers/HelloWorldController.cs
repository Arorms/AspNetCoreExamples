using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // View of HelloWorld index
    public IActionResult Index()
    {
        return View();
    }

    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}

    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name},  is: {id}");
    }
}