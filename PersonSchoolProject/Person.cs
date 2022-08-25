using System.Text.RegularExpressions;

namespace CodeAlong;

public class Person
{
    public string? Name { get; set; }

    private string? _email;
    public string? Email
    {
        get => _email; 
        set
        {
            if (value == null || !ValidateEmail(value))
                throw new ArgumentException($"Not a valid email.");
            
            _email = value;
        }
    }
    
    private string? _password;
    public string? Password
    {
        get => _password;
        set
        {
            if (value == null || !ValidatePassword(value)) 
                throw new ArgumentException($"Can't use {value}. Password needs to contain both small and big letters, a minimum of one number and more than 5 characters.");
            _password = value;
        }
    }

    public DateTime DoB { get; set; }
    
    public int Age
    {
        get
        {
            var today = DateTime.Today;
            var age = today.Year - DoB.Year;

            return DoB.DayOfYear <= today.DayOfYear ? age : age - 1;
        }
    }

    private static bool ValidateEmail(string email)
    {
        // Source: http://thedailywtf.com/Articles/Validating_Email_Addresses.aspx
        var regex = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
        return regex.IsMatch(email);
    }
    
    private static bool ValidatePassword(string password)
    {
        // At least one upper case letter, one lower case letter, one number and 6 characters long
        // Source: https://stackoverflow.com/questions/19605150/regex-for-password-must-contain-at-least-eight-characters-at-least-one-number-a
        var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$");
        
        return regex.IsMatch(password);
    }
}