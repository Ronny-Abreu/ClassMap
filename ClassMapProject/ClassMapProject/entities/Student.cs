public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Career { get; set; }

    public Student(string name, int age, string career)
    {
        this.Name = name;
        this.Age = age;
        this.Career = career;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nStudent: {Name}, Age: {Age}, Career: {Career}");
    }
}
