using System.Collections.Generic;
namespace RectangleApplication {
    class Rectangle {
        double width;
        double length;

    public void Details() {
        length = 12;
        width = 8;
    }
    public double GetArea() {
        return length * width;
    }
    public void Display() {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width : {0}", width);
        Console.Write("Area  : {0}\n", GetArea());
    }
    }
    class ExecuteRectangle {
        static void Main(string[] args) {
            Rectangle rect = new Rectangle();
            rect.Details();
            rect.Display();
            Console.ReadLine();
    }
    }
}