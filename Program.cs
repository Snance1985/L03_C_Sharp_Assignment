string? readUserInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

   string? myName = readUserInput("Enter your name: ");
        int age;

        string? ageInput = readUserInput("Enter your age: ");

        try
        {
            age = int.Parse(ageInput);
            Console.WriteLine("Name: " + myName);
            Console.WriteLine("Age: " + age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid age input. Please enter a valid number.");
        }

        Console.WriteLine("Your name is " + myName + " and you are " + ageInput + " years old.");