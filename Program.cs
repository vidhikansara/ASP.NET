using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDelegates
{

    public delegate void calArea(double a,double b);
    public delegate void calTriangle(double c, double d);

    public class Area
    {
        public static void AreaRec(double n1, double n2)
        {
            Console.WriteLine("Area of rectangle : " + (n1 * n2));
        }

        public static void AreaTri(double n3,double n4)
        {
            Console.WriteLine("Area of Triangle : " + (n3*n4)/2);
        }
    }

    class Program
    {

      
        static void Main(string[] args)
        {
            double number1, number2;
            Console.WriteLine("enter number 1:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number 2:");
            number2 = Convert.ToDouble(Console.ReadLine());

            calArea area = new calArea(Area.AreaRec);
            area(number1,number2);

            calTriangle tri = new calTriangle(Area.AreaTri);
            tri(number1, number2);

            Console.ReadKey();
        }
    }
}
