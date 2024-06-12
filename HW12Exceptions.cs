// See https://aka.ms/new-console-template for more information

namespace HW12Exceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message)
            : base(message)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age > 120)
            {
                throw new InvalidAgeException("Sorry, Age must be less than 120");
            }
        }
        public static void Main()
        {
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            try
            {
                validate(130);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }

        }
    }
}