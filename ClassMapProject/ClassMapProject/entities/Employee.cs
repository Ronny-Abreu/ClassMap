public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public Employee(string name, int age, string position)
    {
        this.Name = name;
        this.Age = age;
        this.Position = position;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, Position: {Position}");
    }
}
