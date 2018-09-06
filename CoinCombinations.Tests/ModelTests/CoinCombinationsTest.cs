using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombinations.Models;
using System.Collections.Generic;
using System;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinChangeTest
  {
    [TestMethod]
    public void CoinCombinations_Constructor()
    {
      int cents = 54;
      CoinChange coinChange = new CoinChange(cents);
      Assert.AreEqual(cents, coinChange.getCents());
    }
    [TestMethod]
    public void calculateQuarters_True()
    {
      int cents = 54;
      CoinChange coinChange = new CoinChange(cents);
      Assert.AreEqual(2, CoinChange.calculateQuarters(cents));
    }
    [TestMethod]
    public void calculateDimes_True()
    {
      int cents = 54;
      CoinChange coinChange = new CoinChange(cents);
      Assert.AreEqual(5, CoinChange.calculateDimes(cents));
    }
    [TestMethod]
    public void calculateNickels_True()
    {
      int cents = 54;
      CoinChange coinChange = new CoinChange(cents);
      Assert.AreEqual(10, CoinChange.calculateNickels(cents));
    }
    [TestMethod]
    public void calculate_True()
    {
      int cents = 89;
      CoinChange coinChange = new CoinChange(cents);
      coinChange.calculate();
      Assert.AreEqual(3, coinChange.getQuarters());
      Assert.AreEqual(1, coinChange.getDimes());
      Assert.AreEqual(0, coinChange.getNickels());
      Assert.AreEqual(4, coinChange.getPennies());
    }
  }
}
