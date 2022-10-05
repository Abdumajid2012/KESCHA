
        Console.Write("Enter your name:  ");
        string name = Console .ReadLine ();
        string greeting = $"Hello, {name}";
        Console.WriteLine(greeting);
        Console.Write("Enter your age:  ");
        string ageAsString = Console.ReadLine();
        Console.WriteLine("Converting.....");
        int age = Convert.ToInt32(ageAsString);
        Console.WriteLine($"Successfully converted!  {age} ");
        int keschasAge = 2;
        int ageDifference = age - keschasAge;
        Console.WriteLine($"The difference between your and Kescha`s age is {ageDifference}");
        System.Console.WriteLine($"You are older KESCHA :  {ageDifference > 0}");
         System.Console.WriteLine($"You are older KESCHA :  {age >  keschasAge}");
         System.Console.WriteLine($"You are younger KESCHA :  {age < keschasAge}");
         System.Console.WriteLine($"You are older  that equal to KESCHA :  {age >=  keschasAge}");
         System.Console.WriteLine($"You are younger thet equal to KESCHA :  {age <= keschasAge}"); 
         System.Console.WriteLine($"You are the same age as KESCHA:  {age == keschasAge}");
         System.Console.WriteLine($"You are not the same age as KESCHA:  {age != keschasAge}");


