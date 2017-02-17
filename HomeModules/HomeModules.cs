using Nancy;
using ScrabbleApp.Objects;
using System.Collections.Generic;

namespace ScrabbleApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        string word = Request.Form["word"];
        Scrabble newWord = new Scrabble(word);
        int result = newWord.CalculateScore();
        return View["index.cshtml", result];
      };

      Post["/new"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
