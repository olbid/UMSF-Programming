using System;
using System.Text;

class Triangle
{
    public double a, b, c;

    public Triangle(double x, double y, double z)
    {
        a = x;
        b = y;
        c = z;
    }

    public double Perimeter()
    {
        return a + b + c;
    }

    public double Area()
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }

    public string Print()
    {
        return "a: " + Convert.ToString(a) + ", b: " + Convert.ToString(b) + ", c: " + Convert.ToString(c);
    }

}

class Bill
{
    public int par;
    public int number;
    private int[] possible_pars = [2, 5, 10, 20, 50, 100, 200, 500, 1000];

    public Bill(int x, int y)
    {
        if (possible_pars.Contains(x)) 
        {
            par = x;
            number = y;
        }
        else
        {
            Console.WriteLine("Такого номіналу не існує!");
            
        }
        
    }

    public int Sum()
    {
        return par * number;
    }

    public string Print()
    {
        return "Кількість купюр: " + number + ", номіналом: " + par; 
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Завдання №1");

        Triangle t1 = new Triangle(4, 6, 8);

        Console.WriteLine("Периметр: " + t1.Perimeter());
        Console.WriteLine("Площа: " + t1.Area());
        Console.WriteLine(t1.Print());

        Console.WriteLine("Завдання №2");

        Bill b1 = new Bill(100, 900);
        Console.WriteLine(b1.Print());
        Console.WriteLine("Сума: " + b1.Sum());
    }

}