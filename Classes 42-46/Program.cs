using System;
using Classes_42_46;

// Exercise 42 and 43:

bool playPointAgain = false;
do
{
    Console.WriteLine("Enter an X coordinate");
    Point.X = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter a Y coordinate");
    Point.Y = double.Parse(Console.ReadLine());
    double distance = Point.CalculateDistance();
    Console.WriteLine($"You have created a point object: {Point.X}, {Point.Y}. It has a distance of {distance}");
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAgreePoint = Console.ReadLine();
    if (userAgreePoint == "y")
    {
        playPointAgain = true;
    }
    else
    {
        break;
    }
} while (playPointAgain == true);
Console.WriteLine("Goodbye!");

// Exercise 44:

bool playCoordinatesAgain = false;
do
{
    Console.WriteLine("Enter 2 coordinates for a point seperated by a space");
    string userPoints1 = Console.ReadLine();
    string[] userCoordinates1 = userPoints1.Split(" ");
    double x1 = double.Parse(userCoordinates1[0]);
    double y1 = double.Parse(userCoordinates1[1]);
    Console.WriteLine("Enter 2 more coordinates for another point separated by a space");
    string userPoints2 = Console.ReadLine();
    string[] userCoordinates2 = userPoints2.Split(" ");
    double x2 = double.Parse(userCoordinates2[0]);
    double y2 = double.Parse(userCoordinates2[1]);
    (double X, double Y) midpoint = Point.CalculateMidpoint(x1, y1, x2, y2);
    Console.WriteLine($"The midpoint between ({userCoordinates1[0]}, {userCoordinates1[1]}) and ({userCoordinates2[0]}, {userCoordinates2[1]}) is {midpoint}");
    Console.WriteLine("Would you like to play again? (y/n)");
    string userAgreeCoordinates = Console.ReadLine();
    if (userAgreeCoordinates == "y")
    {
        playCoordinatesAgain = true;
    }
    else
    {
        break;
    }
} while (playCoordinatesAgain == true);
Console.WriteLine("Goodbye!");

// Exercise 45:

bool playSquareAgain = false;
do
{
    Console.WriteLine("Enter a side length for a square to see the perimeter and area");
    Square.SideLength = double.Parse(Console.ReadLine());
    Square userSquare = new Square(Square.SideLength);
    double perimeter = Square.CalculatePerimeter();
    double area = Square.CalculateArea();
    Console.WriteLine($"Your square has a side length of {Square.SideLength}. Its area is {area}, and its perimeter is {perimeter}");
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAgreeSquare = Console.ReadLine();
    if (userAgreeSquare == "y")
    {
        playSquareAgain = true;
    }
    else
    {
        break;
    }
} while (playSquareAgain == true);
Console.WriteLine("Goodbye!");

// Exercise 46:

bool playTriangleAgain = false;
do
{
    Console.WriteLine("Enter 3 side lengths of a triangle - each number should be separated by a space");
    string userTriangle = Console.ReadLine();
    string[] triangleNumbers = userTriangle.Split(" ");
    if (triangleNumbers.Length == 3)
    {
        Triangle.Side1Length = double.Parse(triangleNumbers[0]);
        Triangle.Side2Length = double.Parse(triangleNumbers[1]);
        Triangle.Side3Length = double.Parse(triangleNumbers[2]);
    }
    double trianglePerimeter = Triangle.CalculatePerimeter();
    double triangleArea = Triangle.CalculateArea();
    Console.WriteLine($"Your triangle has side lenghts of {triangleNumbers[0]}, {triangleNumbers[1]}, and {triangleNumbers[2]}. Its area is {triangleArea} and its perimeter is {trianglePerimeter}");
    Console.WriteLine("Would you like to play again? (y/n)");
    string userAgreeTriangle = Console.ReadLine();
    if (userAgreeTriangle == "y")
    {
        playTriangleAgain = true;
    }
    else
    {
        break;
    }
} while (playTriangleAgain == true);
Console.WriteLine("Goodbye!");
