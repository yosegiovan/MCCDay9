using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCDay9
{
    class Shape
    {
        protected double side, radius, length, width;

        public Shape()
        {
            side = 0;
            radius = 0;
            length = 0;
            width = 0;
        }

        public virtual double CountSquareArea()
        {
            return side * side;
        }

        public virtual double CountRectangleArea()
        {
            return length * width;
        }

        public virtual double CountCircleArea()
        {
            return 3.14 * radius * radius;
        }
    }

    class Square : Shape
    {
        public Square()
        {
            side = 0;
        }

        public Square(double input_side)
        {
            side = input_side;
        }

        public override double CountSquareArea()
        {
            return side * side;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(double input_length, double input_width)
        {
            length = input_length;
            width = input_width;
        }

        public override double CountRectangleArea()
        {
            return length * width;
        }
    }

    class Circle : Shape
    {
        public Circle()
        {
            radius = 0;
        }

        public Circle(double input_radius)
        {
            radius = input_radius;
        }

        public override double CountCircleArea()
        {
            return 3.14 * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int option, option2;
                Console.WriteLine("\nChoose which Shape you want to count : ");
                Console.WriteLine("1. Square \n2. Rectangle \n3. Circle\n4. Try Polymorphism");
                while (true)
                {
                    string input = Console.ReadLine(); //get the input
                    int num;
                    try
                    {
                        if (Convert.ToInt32(input) != 1 && Convert.ToInt32(input) != 2
                        && Convert.ToInt32(input) != 3 && Convert.ToInt32(input) != 4)
                        {
                            Console.WriteLine("\nPlease choose available options");
                        }
                        else
                        {
                            option = Convert.ToInt32(input);
                            break;
                        }
                    } catch (Exception)
                    {
                        Console.WriteLine("Please input number only");
                    }
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nYou choose to calculate Square's area");
                        Console.WriteLine("Enter the number of Square's side");
                        double input_side;
                        while (true)
                        {
                            string input = Console.ReadLine(); //get the input
                            double num;
                            try
                            {
                                input_side = Convert.ToDouble(input);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nPlease input number only");

                            }
                        }
                        Square square = new Square(input_side);
                        Console.WriteLine("Square's area is " + square.CountSquareArea());
                        break;
                    case 2:
                        Console.WriteLine("\nYou choose to calculate Rectangle's area");
                        Console.WriteLine("Enter the number of Rectangle's length");
                        double input_length, input_width;
                        while (true)
                        {
                            string input = Console.ReadLine(); //get the input
                            double num;
                            try
                            {
                                input_length = Convert.ToDouble(input);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nPlease input number only");
                            }
                        }
                        Console.WriteLine("\nEnter the number of Rectangle's width");
                        while (true)
                        {
                            string input = Console.ReadLine(); //get the input
                            double num;
                            try
                            {
                                input_width = Convert.ToDouble(input);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nPlease input number only");
                            }
                        }
                        Rectangle rectangle = new Rectangle(input_length, input_width);
                        Console.WriteLine("Square's area is " + rectangle.CountRectangleArea());
                        break;
                    case 3:
                        Console.WriteLine("\nYou choose to calculate Circle's radius");
                        Console.WriteLine("Enter the number of Circle's radius");
                        double input_radius;
                        while (true)
                        {
                            string input = Console.ReadLine(); //get the input
                            double num;
                            try
                            {
                                input_radius = Convert.ToDouble(input);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nPlease input number only");
                            }
                        }
                        Circle circle = new Circle(input_radius);
                        Console.WriteLine("Circle's area is " + circle.CountCircleArea());
                        break;
                    case 4:
                        Console.WriteLine("\nYou choose to Try Polymorphism");
                        Console.WriteLine("Enter the number of Circle's radius");
                        double input_radius_1;
                        while (true)
                        {
                            string input = Console.ReadLine(); //get the input
                            double num;
                            try
                            {
                                input_radius_1 = Convert.ToDouble(input);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nPlease input number only");
                            }
                        }
                        Shape circle1 = new Circle(input_radius_1);
                        Console.WriteLine("Circle's area is " + circle1.CountCircleArea());
                        break;
                }

                Console.WriteLine("\nDo you want to count another area of shape?");
                Console.WriteLine("1. Yes \n2. No");
                while (true)
                {
                    string input = Console.ReadLine(); //get the input
                    int num;
                    if (!int.TryParse(input, out num))
                    {
                        Console.WriteLine("\nPlease input number only");
                    }
                    else if (Convert.ToInt32(input) != 1 && Convert.ToInt32(input) != 2)
                    {
                        Console.WriteLine("\nPlease choose available options");
                    }
                    else
                    {
                        option2 = Convert.ToInt32(input);
                        break;
                    }
                }

                if (option2 == 2)
                {
                    break;
                }
            }

            Console.WriteLine("\nThank you!");
            Console.ReadLine();
        }
    }
}
