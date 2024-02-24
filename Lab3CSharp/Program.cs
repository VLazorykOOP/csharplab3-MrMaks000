using System.Drawing;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3 ");

            IsoscelesTriangle[] triangles = new IsoscelesTriangle[]
            {
                new IsoscelesTriangle(5, 4),
                new IsoscelesTriangle(3, 3),
                new IsoscelesTriangle(3, 2, Color.Aqua)
            };

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine($"\nTriange {i}");
                triangles[i].DisplayFields();
                Console.WriteLine($"Perimeter: {triangles[i].Perimeter()}");
                Console.WriteLine($"Area: {triangles[i].Area():F2}");
                Console.WriteLine($"Right triangle: {triangles[i].RightTriangle()}");
            }
        }
    }
}
