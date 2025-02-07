public class Member
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Workshop { get; set; }

    public Member(string name, int age, string workshop)
    {
        this.Name = name;
        this.Age = age;
        this.Workshop = workshop;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Member: {Name}, \nAge: {Age}, \nWorkshop: {Workshop}");
    }
}
