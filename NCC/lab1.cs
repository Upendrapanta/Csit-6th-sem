using System;

class Student
{
    public string Name { get; set; }
    public int Roll { get; set; }
    public double Marks { get; set; }

    public Student(string name, int roll, double marks)
    {
        Name = name;
        Roll = roll;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Roll : " + Roll);
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Aarogya", 101, 89.5);
        s1.Display();

        Console.ReadKey();
    }
}