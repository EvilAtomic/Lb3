using System;

class Point
{
    // Числові та рядкове поля
    private double x;
    private double y;
    private string name;

    // Конструктор класу Point
    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    // Властивості для отримання значень полів
    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points;

    // Конструктор класу Figure для різної кількості точок
    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    // Метод для розрахунку довжини сторони багатокутника
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Метод для розрахунку периметра багатокутника
    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо об'єкти класу Point для точок
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 1, "B");
        Point point3 = new Point(1, 1, "C");

        // Створюємо об'єкт класу Figure і викликаємо метод CalculatePerimeter
        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();

        Console.ReadLine(); // Затримка консолі
    }
}
