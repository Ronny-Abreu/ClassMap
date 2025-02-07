public class ExAlumn
{
    public string Name { get; set; }
    public int GraduationYear { get; set; }
    public string Career { get; set; }

    public ExAlumn(string name, int graduationYear, string career)
    {
        this.Name = name;
        this.GraduationYear = graduationYear;
        this.Career = career;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"\nEx-Alumn: {Name}, graduated in {GraduationYear}, specialized in {Career}");
    }
}
