using System.Security.Cryptography.X509Certificates;

namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of the class and call methods
            Circle circle1 = new Circle(5);
            circle1.GetCircleArea();
            circle1.GetCircleVolume();
            
            Circle circle2 = new Circle(6);
            circle2.GetCircleArea();
            circle2.GetCircleVolume();

            Triangle triangle = new Triangle(10, 15);
            triangle.GetTriangleArea();
        }

    }

    public class Circle
    {
        //fields in class
        float _pi;
        int _radius;

        //create constructor and initialize fields
        public Circle(int radius)
        {
            _pi = 3.141f;
            _radius = radius;
        }

        //method to calculate area and print it out
        public void GetCircleArea()
        {
            float circleArea = _radius * _radius * _pi;
            Console.WriteLine($"Arean av en cirkel med radie {_radius} är {circleArea}");
        }

        public void GetCircleVolume()
        {
            float circleVolume = 4 * _pi * _radius * _radius * _radius / 3;
            Console.WriteLine($"Volymen av en sfär med radie {_radius} är {circleVolume}");
        }


    }

    public class Triangle
    {
        //create fields
        int _basis;
        int _height;

        //create constructor and initialize fields
        public Triangle(int basis, int height)
        {
            _basis = basis;
            _height = height;
        }
        
        //method to calculate area and print it out
        public void GetTriangleArea()
        {
            float triangleArea = _basis * _height / 2;
            Console.WriteLine($"Arean av en triangel med basen {_basis} och höjden {_height} är {triangleArea}: ");
        }
    }
}