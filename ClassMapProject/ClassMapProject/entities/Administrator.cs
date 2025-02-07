public class Administrator
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }

    public Administrator(string name, int age, string role)
    {
        this.Name = name;
        this.Age = age;
        this.Role = role;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nAdministrator: {Name}, Age: {Age}, Role: {Role}");
    }
}
