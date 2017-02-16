using System;
using System.Collections.Generic;

namespace ScrabbleApp.Objects

{
  public class Scrabble
  {
    public string _word;
    public static Dictionary<char, int> scoreDict = new Dictionary<char,int>()
    {
      {'a', 1},
      {'e', 1},
      {'i', 1},
      {'o', 1},
      {'u', 1},
      {'l', 1},
      {'n', 1},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'d', 2},
      {'g', 2},
      {'b', 3},
      {'c', 3},
      {'m', 3},
      {'p', 3},
      {'f', 4},
      {'h', 4},
      {'v', 4},
      {'w', 4},
      {'y', 4},
      {'k', 5},
      {'j', 8},
      {'x', 1},
      {'q', 10},
      {'z', 10},
    };

    //Getter
    public string GetWord()
    {
      return _word;
    }

    //Constructor
    public Scrabble(string newWord)
    {
      _word = newWord;
    }

    public int CalculateScore()
    {
      char[] newWord = GetWord().ToCharArray();

      int wordScore = 0;
      foreach(char letter in newWord)
      {
        foreach (KeyValuePair<char, int> result in scoreDict)
        {
          if (letter == result.Key)
          {
            wordScore += result.Value;
          }
        }
      }
      return wordScore;
    }
  }
}
