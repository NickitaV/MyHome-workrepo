// Decompiled with JetBrains decompiler
// Type: rand_application.Program
// Assembly: rand application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C9B89F6C-95EB-4508-A3D0-B3A7695004D9
// Assembly location: E:\Geek Brain\7 zadanie\rand application\rand application\bin\Release\netcoreapp3.1\rand application.dll

using System;

namespace rand_application
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      double OneValue;
      double TwoValue;
      Program.Input(out OneValue, out TwoValue);
      Program.Calc(OneValue, TwoValue);
    }

    private static void Input(out double OneValue, out double TwoValue)
    {
      Console.WriteLine("Введите первое число");
      OneValue = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите второе число");
      TwoValue = Convert.ToDouble(Console.ReadLine());
    }

    private static void Calc(double One, double Two)
    {
      Console.WriteLine("a-сумма\nb-разность\nc-произведение\nd- частное\n");
      string s = Console.ReadLine();
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(s))
      {
        case 923164629:
          if (!(s == "в"))
            break;
          if (Two == 0.0)
          {
            Console.WriteLine("Делить на ноль нельзя");
            break;
          }
          Console.WriteLine("Частное чисел: " + (One / Two).ToString());
          break;
        case 1023830343:
          if (!(s == "и"))
            break;
          Console.WriteLine("Разность чисел: " + (One - Two).ToString());
          break;
        case 3238372883:
          if (!(s == "ф"))
            break;
          Console.WriteLine("Cумма чисел: " + (One + Two).ToString());
          break;
        case 3288705740:
          if (!(s == "с"))
            break;
          Console.WriteLine("Произведение чисел: " + (One * Two).ToString());
          break;
        case 3775669363:
          if (!(s == "d"))
            break;
          if (Two == 0.0)
          {
            Console.WriteLine("Делить на ноль нельзя");
            break;
          }
          Console.WriteLine("Частное чисел: " + (One / Two).ToString());
          break;
        case 3826002220:
          if (!(s == "a"))
            break;
          Console.WriteLine("Cумма чисел: " + (One + Two).ToString());
          break;
        case 3859557458:
          if (!(s == "c"))
            break;
          Console.WriteLine("Произведение чисел: " + (One * Two).ToString());
          break;
        case 3876335077:
          if (!(s == "b"))
            break;
          Console.WriteLine("Разность чисел: " + (One - Two).ToString());
          break;
      }
    }
  }
}
