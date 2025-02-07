public class Administrative
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Administrative(string name, int age, string department)
    {
        this.Name = name;
        this.Age = age;
        this.Department = department;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nAdministrative: {Name}, Age: {Age}, Department: {Department}");
    }
}
