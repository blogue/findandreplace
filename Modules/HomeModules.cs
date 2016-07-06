using Nancy;
using FindAndReplace.Objects;
using System.Collections.Generic;
using System.Text;

namespace FindAndReplace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        string inputText = Request.Form["string"];
        StringBuilder newInputText = new StringBuilder(inputText);
        Replacer.ReplaceWords(newInputText, Request.Form["to-replace"], Request.Form["replace-with"], Request.Form["all"]);
        return View["result.cshtml", Replacer.userOutput];
      };
    }
  }
}
