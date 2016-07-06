using System;
using System.Collections.Generic;
using System.Text;

namespace FindAndReplace.Objects
{
  public class Replacer
  {
    public static StringBuilder userOutput;
    public static void ReplaceWords(StringBuilder userString, string WordToReplace, string ReplacementWord, string all)
    {
      if (all != "true")
      {
        List<string> afterWordChars = new List<string> { " ", ",", ".", "-", ";", ":", "?", "!"};
        foreach (string character in afterWordChars)
        {
          userString.Replace(WordToReplace + character, ReplacementWord + character);
        }
      }
      else
      {
        userString.Replace(WordToReplace, ReplacementWord);
      }
      userOutput = userString;
    }
  }
}
