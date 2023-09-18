using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter hours: ");
    var x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("Please enter miles: ");
    var z = Convert.ToDouble(Console.ReadLine());

    var y = 200;
    var b = 150;
    var a = 2;

    Console.WriteLine("({0} * {3}) + ({1} * {4}) + {2} = {5}", x, z, y, b, a, (x * b) + (z * a) + (y));
    //Console.WriteLine("{0} inches is {2} centimeters", x, y, (x *y));
  }
}