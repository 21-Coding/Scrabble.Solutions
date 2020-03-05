using System;
using Game.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
     Scrabble newGame = new Scrabble();
     char[] userLetters = newGame.RandomLetters();
     Console.WriteLine(userLetters);

     Console.WriteLine("Make as many words as you can with the 7 presented letters!");
     string madeWords = Console.ReadLine();
     string[] wordsArray = newGame.CutAtComma(madeWords);
     
     for (int i = 0; i < wordsArray.Length; i++)
     {
     Console.WriteLine(newGame.CalculateWordScore(wordsArray[i]));


     }
    }
  }

}