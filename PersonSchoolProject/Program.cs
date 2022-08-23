// See https://aka.ms/new-console-template for more information

using CodeAlong;

var person = new Person();

Console.WriteLine("Enter your details below...");
Thread.Sleep(1000);

person.Name = Input.GetName();
Console.WriteLine($"Your name is {person.Name} - lovely");
Thread.Sleep(1000);

person.DoB = Input.GetDateOfBirth();
Console.WriteLine($"Aha, so your age is {person.Age}");
Thread.Sleep(1000);

while(true)
{
    try
    {
        person.Email = Input.GetEmail();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        continue;
    }

    break;
}
Console.WriteLine($"Your email is {person.Email} - cool");
Thread.Sleep(1000);

while(true)
{
    try
    {
        person.Password = Input.GetPassword();
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        continue;
    }

    break;
}
Console.WriteLine($"Your safe and secret password is {person.Password} - nice m8");
Thread.Sleep(1000);





