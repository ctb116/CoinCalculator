using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class CoinChange
  {
    private int _cents;
    private int _quarters;
    private int _dimes;
    private int _nickels;
    private int _pennies;

    public CoinChange(int cents)
    {
      _cents = cents;
      _quarters = 0;
      _dimes = 0;
      _nickels = 0;
      _pennies = 0;
    }
    public int getCents()
    {
      return _cents;
    }

    public int getQuarters()
    {
      return _quarters;
    }

    public void setQuarters(int quarter)
    {
      if (quarter >= 0)
        _quarters = quarter;
      else
      {
        Console.WriteLine("Invalid number");
      }
    }

    public static int calculateQuarters(int cents)
    {
      return cents / 25;
    }

    public int getDimes()
    {
      return _dimes;
    }

    public void setDimes(int dime)
    {
      if (dime >= 0)
        _dimes = dime;
      else
      {
        Console.WriteLine("Invalid number");
      }
    }

    public static int calculateDimes(int cents)
    {
      return cents / 10;
    }

    public int getNickels()
    {
      return _nickels;
    }

    public void setNickels(int nickel)
    {
      if (nickel >= 0)
        _nickels = nickel;
      else
      {
        Console.WriteLine("Invalid number");
      }
    }

    public static int calculateNickels(int cents)
    {
      return cents / 5;
    }

    public int getPennies()
    {
      return _pennies;
    }

    public void setPennies(int penny)
    {
      if (penny >= 0)
        _pennies = penny;
      else
      {
        Console.WriteLine("Invalid number");
      }
    }

    public void calculate()
    {
      int quotient = CoinChange.calculateQuarters(_cents);
      int remainder = _cents - quotient*25;
      this.setQuarters(quotient);
      quotient = CoinChange.calculateDimes(remainder);
      remainder = remainder - quotient*10;
      this.setDimes(quotient);
      quotient = CoinChange.calculateNickels(remainder);
      remainder = remainder - quotient*5;
      this.setNickels(quotient);
      this.setPennies(remainder);
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your amount of cash in cents");
      int inputCents = int.Parse(Console.ReadLine());
      CoinChange changecheck = new CoinChange(inputCents);
      changecheck.calculate();

      Console.WriteLine("Here is your change");
      Console.WriteLine("Quarters: " + changecheck.getQuarters());
      Console.WriteLine("Dimes: " + changecheck.getDimes());
      Console.WriteLine("Nickels: " + changecheck.getNickels());
      Console.WriteLine("Pennies: " + changecheck.getPennies());
    }
  }
}
