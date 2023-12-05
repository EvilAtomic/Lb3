using System;

class Rectangle
{
    // Поля класу
    private double side1;
    private double side2;

    // Конструктор класу
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметра прямокутника
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Властивість для отримання площі прямокутника
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для отримання периметра прямокутника
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main()
    {
        // Зчитуємо довжини сторін від користувача
        Console.Write("Введіть довжину сторони 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть довжину сторони 2: ");
        double side2 = double.Parse(Console.ReadLine());

        // Створюємо об'єкт класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виводимо периметр та площу на екран
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");

        Console.ReadLine(); // Затримка консолі
    }
}
