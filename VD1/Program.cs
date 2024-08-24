// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using VD1.VD5;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Car(string Make, string Model, int Year)
    {
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
    }
    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

// VD2: Viết một chương trình tạo lớp Rectangle với các thuộc tính Length, Width, và phương thức CalculateArea(). Tạo đối tượng Rectangle và tính diện tích.
class Rectangle
{
    // Thuoc tinh tu dong
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // CalculateArea() Method
    public double CalculateArea()
    {
        return Length * Width;
    }
}

//VD 3: Viết một chương trình tạo lớp Person với các thuộc tính Name, Age, và phương thức DisplayInfo().Tạo lớp con Student kế thừa từ lớp Person, thêm thuộc tính StudentID và
//phương thức Study(). Tạo đối tượng Student và gọi các phương thức
class Person // Base class
{
    //Automatic properties
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructors
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // DisplayInfo Method
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

}
class Student : Person // Derived class
{
    // Automatic properties
    public string StudentID {  get; set; }
    //Constructors
    public Student(string name, int age, string studentID) : base(name, age)
    {
        this.StudentID = studentID;
    }
    // Study() Method
    public void Study()
    {
        Console.WriteLine($" Study: {StudentID}");
    }

}

/*VD4: Viết một chương trình tạo lớp Shape với phương thức ảo CalculateArea(). Tạo các lớp
con Circle và Square kế thừa từ lớp Shape, triển khai phương thức CalculateArea(). Tạo
đối tượng của các lớp con và tính diện tích*/

abstract class Shape //Base class
{
    //Abstraction
    public abstract double CalculateArea();
}

class Circle : Shape // Circle class derived from Shape class 
{
    // automatic properties
    public double Radius { get; set; }
    // Constructors
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    // CalculateArea() Method derived from Base class
    public override double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }

}
class Square : Shape // Square class derived from Shape classs
{
    // Automatic properties
    public double Length { get; set; }
    public double Width {  get; set; }
    // Constructors
    public Square(double length, double width)
    {
        this.Length = length;
        this.Width = width;
    }
    // CalculateArea() Method from Shape base class
    public override double CalculateArea()
    {
        return Width * Length;
    }
}

// Main
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select !" +
            "\nEX1: 1 ");
        string input = Console.ReadLine();
        int select = int.Parse( input );
        switch (select)
        {
            case 1:
                Console.WriteLine(" Example 1");
                Car car = new Car("Cacbon", "VFST", 2020);
                car.DisplayInfo();
                break;
            case 2:
                Console.WriteLine("Vi Du 2");
                Rectangle rectangle = new Rectangle(5, 10);
                Console.WriteLine($"The area of ​​the rectangle is: {rectangle.CalculateArea()}");
                break;
            case 3:
                Console.WriteLine("Vi du 3");
                Student student = new Student("Lap", 2, "DTC225180193");
                student.DisplayInfo();
                student.Study();
                break;
            case 4:
                Console.WriteLine("Vi Du 4");
                Circle circle = new Circle(99);
                Square square = new Square(17, 37);
                Console.WriteLine($"Area of Circle: {circle.CalculateArea()}, Area of Sqare: {square.CalculateArea()}");
                break;
            case 5:
                Console.WriteLine("Vi Du 5");
                Dog dog = new Dog();
                Cat cat = new Cat();
                break;
            case 6:




            default: 
                Console.WriteLine("Not find your select !");
                break;

        }

    }
}