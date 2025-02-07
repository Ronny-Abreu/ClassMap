public class Teacher
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject)
    {
        this.Name = name;
        this.Age = age;
        this.Subject = subject;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nTeacher: {Name}, Age: {Age}, Subject: {Subject}");
    }
}
