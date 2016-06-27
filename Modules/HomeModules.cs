using Nancy;
using Parcels.Objects;

namespace Parcels
{
  public class HomeModules : NancyModule
  {
    public HomeModules()
    {
      Get["/"] = _ => {
        return View["form.html"];
      };
      Get["/results"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables
        {
          Width = Request.Query["width"],
          Length = Request.Query["length"],
          Height = Request.Query["height"],
          Weight = Request.Query["weight"]
        };
        return View["results.cshtml", myParcelVariables];
      };
    }
  }
}
