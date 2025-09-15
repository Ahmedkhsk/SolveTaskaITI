using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public abstract class Shape :  IDrawable
    {
        public abstract double Area();

        public abstract void Draw();
    }
    public interface IDrawable
    {
        public void Draw();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
    public class Rectangle : Shape 
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
        public override double Area()
        {
            return Width * Height;
        }
    }

}
