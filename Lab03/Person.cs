﻿using System;
public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public virtual void View()
    {
        Console.WriteLine($"Osoba: {FirstName} {LastName}, Wiek: {Age}");
    }
}