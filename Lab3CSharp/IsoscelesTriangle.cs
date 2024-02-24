using System.Drawing;

namespace Lab3CSharp
{
    internal class IsoscelesTriangle
    {
        private double side;
        private double basis; 
        private Color color; 

        public IsoscelesTriangle(double side, double basis, Color color)
        {
            this.side = side;
            this.basis = basis;
            this.color = color;
        }

        public IsoscelesTriangle(int side, int b) : this(side, b, Color.White) { }

        public double A { get { return side; } set { side = value; } }

        public double B { get { return basis; } set { basis = value; } }

        public Color Color { get { return color; } }       

        public double Perimeter()
        {
            return 2 * side + basis;
        }

        public double Area()
        {
            return 0.5 * basis * Math.Sqrt((side * side) - ((basis * basis) / 4));
        }

        public bool RightTriangle()
        {
            return side == basis;
        }

        public void DisplayFields()
        {
            Console.WriteLine($"Side: {side}");
            if (RightTriangle() == false)
                Console.WriteLine($"Basis: {basis}");
            Console.WriteLine($"Color: {color.Name}");
        }
    }
}
