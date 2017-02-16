using System;
using System.Collections.Generic;

namespace ScrabbleApp.Objects

{
  public class Scrabble
  {
    public string _word;


    public Scrabble(string newWord)
    {
      _word = newWord;
    }

    public int CalculateScore()
    {
      return 1;
    }
  }
}
