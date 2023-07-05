// See https://aka.ms/new-console-template for more information





namespace MyProgram
{
    public class Program 
    {
      public static void Main(string[] args)
        {
            
            EmailValidator emailValidator = new EmailValidator();
            
            try
            {
               bool IsValid = emailValidator.Validate("abdullah.manafli38@gmail.com");
                Console.WriteLine(IsValid);
            }
            catch (NullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ShortEmailException ex)
            {

              Console.WriteLine(ex.Message);
            }
            catch (NotAnEmailAdressException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Congratulation! You has created email adress!");
            }

        }
    }
    public class NullException : Exception 
    {
        public NullException(string message) : base(message)
        {
            
        }
    }
    public  class NotAnEmailAdressException : Exception
    {
        public NotAnEmailAdressException(string message) : base(message)
        {

        }
    }
    public class ShortEmailException : Exception 
    {
        public ShortEmailException(string message) :base(message)
        {
            
        }
    }

    public class EmailValidator
    {
        public  bool Validate(string email)
        {
            if (email == null)
            {
                throw new NullException("Your email is null. Please write your email adress!");
            }
            if (email.Length < 10)
            {
                throw new ShortEmailException("Email adress is short than 10 characters");

            }
            if (!email.EndsWith("@gmail.com"))
            {
                throw new NotAnEmailAdressException("Your email is wrong format");
            }
            return true;
            
            
            
        }
    }
}





