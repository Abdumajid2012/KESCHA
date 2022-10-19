using System;
using KESCHA.Classes;

internal class NewBaseType
{
    private static void Main(string[] args)
    {
        string password = "";

        do
        {
            Console.WriteLine("Enter password:.........");
            password = Console.ReadLine();
        } while (password != "Abdumajid2012");

        Console.Write("Enter your name:  ");
        string name = Console.ReadLine();
        string greeting = $"Hello, {name}";
        Console.WriteLine(greeting);
        Console.Write("Enter your age:  ");
        string ageAsString = Console.ReadLine();
        Console.WriteLine("Converting.....");
        int age = Convert.ToInt32(ageAsString);
        Console.WriteLine($"Successfully converted!  {age} ");

        Animal kescha = new Animal(animalName: "Kescha", userAge: age, animalAge: 3);
        kescha.Age = 3;
        Console.WriteLine(kescha.Name);
        Console.WriteLine(kescha.Age);
        Car mers = new Car();

        int keschasAge = 2;
        int ageDifference = age - keschasAge;
        if (age > kescha.Age)
        {
            Console.WriteLine($"You are older KESCHA");
        }
        else if (age == kescha.Age)
        {
            Console.WriteLine("You are equal");
        }
        else
        {
            Console.WriteLine("You are younger ");
        }
        if (age < kescha.Age)
        {
            Console.WriteLine("Siz keshandan yosh kichiksiz");
        }
        else if (age == kescha.Age)
        {
            Console.WriteLine("Sizning yoshingiz teng");
        }
        else
        {
            Console.WriteLine("Siz Keshadan yosh kattasiz");
            // }
            string malumot =
                    age >= keschasAge
                            ? "Siz keshandan yosh kattasiz"
                            : "Siz keshandan yosh kichiksiz";

            Console.WriteLine(malumot);

            Console.WriteLine($"The difference between your and Kescha`s age is {kescha.AgeDifference}");
            // System.Console.WriteLine($"You are older KESCHA :  {ageDifference > 0}");
            //  System.Console.WriteLine($"You are older KESCHA :  {age >  keschasAge}");
            //  System.Console.WriteLine($"You are younger KESCHA :  {age < keschasAge}");
            //  System.Console.WriteLine($"You are older  that equal to KESCHA :  {age >=  keschasAge}");
            //  System.Console.WriteLine($"You are younger thet equal to KESCHA :  {age <= keschasAge}"); 
            //  System.Console.WriteLine($"You are the same age as KESCHA:  {age == keschasAge}");
            //  System.Console.WriteLine($"You are not the same age as KESCHA:  {age != keschasAge}");

            string message =
                    age >= 0 && keschasAge >= 0
                            ? "you and kescha's are ages positive"
                            : "you and kescha's  are negative";
            Console.WriteLine(message);
        }
    }
}
