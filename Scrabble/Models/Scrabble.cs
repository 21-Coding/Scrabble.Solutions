using System;
using System.Collections.Generic;
using System.Linq;



namespace Game.Models
{
  public class Scrabble
  {
    private Dictionary<int, char[]> letterDict = new Dictionary <int, char[]>()
    {
      {1, new char[] {'A','E','I','O','U','L','N','R','S','T'}},
      {2, new char[] {'D','G'}},
      {3, new char[] {'B', 'C', 'M', 'P'}},
      {4, new char[] {'F', 'H', 'V', 'W', 'Y'}},
      {5, new char[] {'K'}},
      {8, new char[] {'J', 'X'}},
      {10, new char[] {'Q', 'Z'}}
    };
    char[] alphabetList = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

    public int CalculateWordScore(string word)
    {
      int[] keys = letterDict.Keys.ToArray();
      int totalScore = 0;
      for(int i = 0; i < word.Length; i++)
      {
        for(int x = 0; x < keys.Length; x++)
        {
          if(letterDict[keys[x]].Contains(Char.ToUpper(word[i])))
          {
            Console.WriteLine("adding to total");
            totalScore += keys[x];
          }
        }
      }
      return totalScore;
    }

    public char[] RandomLetters()
    {
      Random randLetters = new Random();
      List<char> charList = new List<char>();
      while(charList.Count < 7)
      {
        int index = randLetters.Next(1, 25);
        charList.Add(alphabetList[index]);
      }
      char[] sevenLetterArr = charList.ToArray();
      return sevenLetterArr;
    }
  }
}