using System;

class TCircle
{
    private double radius;

    public TCircle()
    {
        radius = 1.0;
    }

    public TCircle(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Радiус повинен бути додатнiм числом."); // Радiус -> Радіус
        radius = r;
    }

    public TCircle(TCircle circle)
    {
        radius = circle.radius;
    }

    public void Input()
    {
        while (true) // Цикл для повторного введення
        {
            Console.Write("Введiть радiус кола: "); // Введiть -> Введіть, радiус -> радіус
            radius = Convert.ToDouble(Console.ReadLine());
            if (radius > 0)
                break; // Якщо введено коректний радіус, виходимо з циклу
            else
                Console.WriteLine("Помилка: Радiус повинен бути додатнiм числом. Спробуйте ще раз."); // Радiус -> Радіус, додатнiм -> додатнім
        }
    }

    public void Output()
    {
        Console.WriteLine($"Радiус кола: {radius}"); // Радiус -> Радіус
        Console.WriteLine($"Площа кола: {GetArea()}");
        Console.WriteLine($"Довжина кола: {GetCircumference()}");
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public int CompareTo(TCircle other)
    {
        return radius.CompareTo(other.radius);
    }

    public static TCircle operator +(TCircle a, TCircle b)
    {
        return new TCircle(a.radius + b.radius);
    }

    public static TCircle operator -(TCircle a, TCircle b)
    {
        return new TCircle(Math.Max(0, a.radius - b.radius));
    }

    public static TCircle operator *(TCircle a, double factor)
    {
        return new TCircle(a.radius * factor);
    }

    public static TCircle operator *(double factor, TCircle a)
    {
        return new TCircle(a.radius * factor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TCircle circle1 = new TCircle();
        circle1.Input();
        circle1.Output();

        TCircle circle2 = new TCircle(3.5);
        circle2.Output();

        TCircle circle3 = new TCircle(circle2);
        Console.WriteLine("Копiя другого кола:"); // Копiя -> Копія
        circle3.Output();

        Console.WriteLine(circle1.CompareTo(circle2) > 0 ? "Перше коло бiльше." : "Друге коло бiльше або рiвне першому."); // бiльше -> більше, рiвне -> рівне

        TCircle circle4 = circle1 + circle2;
        Console.WriteLine("Сума радiусiв:"); // радiусiв -> радіусів
        circle4.Output();

        TCircle circle5 = circle2 - circle1;
        Console.WriteLine("Рiзниця радiусiв:"); // Рiзниця -> Різниця, радiусiв -> радіусів
        circle5.Output();

        TCircle circle6 = circle1 * 2;
        Console.WriteLine("Радiус пiсля множення на 2:"); // Радiус -> Радіус
        circle6.Output();
    }
}

