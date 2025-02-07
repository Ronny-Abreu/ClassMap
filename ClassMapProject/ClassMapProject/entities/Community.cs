public class Community
{
    public string Name { get; set; }
    public int YearCreation { get; set; }

    public Community(string name, int yearCreation)
    {
        this.Name = name;
        this.YearCreation = yearCreation;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Welcome to this community called {Name}, created in {YearCreation}.");
    }
}
