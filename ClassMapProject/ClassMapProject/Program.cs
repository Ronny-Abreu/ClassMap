﻿using System;

class Program
{
    static void Main()
    {   
        //COMMUNITY
        Community community = new Community("ITESA", 1935);
        community.ShowInfo();

        //Member
        Member member = new Member("Jendry A.", 16, "Programming");
        member.ShowInfo();

        //EMPLOYEES
        Employee employee1 = new Employee("Ronny A.", 20, "Software Developer");
        Employee employee2 = new Employee("Midu D.", 33, "Project Manager");

        employee1.ShowInfo();
        employee2.ShowInfo();

        // STUDENT
        Student student = new Student("Ana P.", 22, "Computer Science");
        student.ShowInfo();


        // TEACHER
        Teacher teacher = new Teacher("Jordan B.", 35, "programming");
        teacher.ShowInfo();
    }


}