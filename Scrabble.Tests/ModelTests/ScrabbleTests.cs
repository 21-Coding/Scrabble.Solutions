using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void CalculateWordScore_ReturnsScoreOfWord_7()
    {
      Scrabble newGame = new Scrabble();
      int wordScore = newGame.CalculateWordScore("hello");
      Assert.AreEqual(8, wordScore);
    }
    [TestMethod]
    public void RandomLetter_ReturnsRandomLetter_()
    {
      Scrabble newGame = new Scrabble();
      char[] charArray = newGame.RandomLetters();
      Assert.AreEqual(7, charArray.Length);
    }
  }
}