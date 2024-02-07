using System;
using System.ComponentModel;
public class Number{
    double a = 0.25;
    double b = 2.25;

    public void Num(){
        double mul = a * b;
        Console.WriteLine("The product of {0} and {1} is {2}", a, b, mul);
    }
}