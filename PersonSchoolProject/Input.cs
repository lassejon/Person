namespace CodeAlong;

public static class Input
{
    public static DateTime GetDateOfBirth()
    {
        string? dateOfBirthInput;
        DateTime dateOfBirth;
        do
        {
            Console.Write("Type your birthday in the format (dd/MM/yyyy): ");
            dateOfBirthInput = Console.ReadLine();
        } while (!DateTime.TryParseExact(dateOfBirthInput,
                     "d/M/yyyy", 
                     System.Globalization.CultureInfo.InvariantCulture, 
                     System.Globalization.DateTimeStyles.None,
                     out dateOfBirth));

        return dateOfBirth;
    }
    
    public static string GetName()
    {
        string? name;
        do
        {
            Console.Write("Type your name: ");
            name = Console.ReadLine();
        } while (name == null);

        return name;
    }
    
    public static string GetEmail()
    {
        string? email;
        do
        {
            Console.Write("Type your email: ");
            email = Console.ReadLine();
        } while (email == null);

        return email;
    }
    
    public static string GetPassword()
    {
        string? password;
        string? passwordChecker;
        do
        {
            Console.WriteLine("Your password must contain at least one lower case letter, one upper case letter, one number and be at least 6 characters long...");
            Console.Write("Type your password: ");
            password = Console.ReadLine();
            
            Console.Write("Type it again: ");
            passwordChecker = Console.ReadLine();
        } while (password == null || passwordChecker != password);

        return password;
    }
}