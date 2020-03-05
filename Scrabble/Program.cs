using System;
using Game.Models;
using System.Linq;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      bool playAgain = true;
      while(playAgain)
      {
        Scrabble newGame = new Scrabble();
        char[] userLetters = newGame.RandomLetters();
        Console.WriteLine(userLetters);

        Console.WriteLine("Make as many words as you can with the 7 presented letters!");
        string madeWords = Console.ReadLine();
        string[] wordsArray = newGame.CutAtComma(madeWords);
        int totalScore = 0;
        bool validWord = true;
        for (int i = 0; i < wordsArray.Length; i++)
        {
          for(int x = 0; x < wordsArray[i].Length; x++)
          {
            char currentLetter = wordsArray[i][x];
            bool isValidWord = userLetters.Contains(Char.ToUpper(currentLetter));
            if(!isValidWord)
            {
              validWord = false;
              Console.WriteLine(wordsArray[i] + " uses more letters than the 7 provided...");
              break;
            }
          }
          if(validWord)
          {
            totalScore += newGame.CalculateWordScore(wordsArray[i]);
          }
        }
        Console.WriteLine("Your total score is " + totalScore);
        Console.WriteLine("Would you like to play again? (y/n)");
        string playAgainAnswer = Console.ReadLine();
        if(playAgainAnswer == "n")
        {
          playAgain = false;
        }
      }
    }
  }

}