public class Member
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }

    public Member(string name, int age, string role)
    {
        this.Name = name;
        this.Age = age;
        this.Role = role;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nMember: {Name}, {Age} years old, is a {Role} in the community.");
    }
}
