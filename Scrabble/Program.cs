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
    }
  }

}