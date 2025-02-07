using System;

class Program
{
    static void Main()
    {
        Community community = new Community("ITESA", 1935);
        community.ShowInfo();

        Member member = new Member("Jendry J.", 16, "Programming");
        member.ShowInfo();
    }


}