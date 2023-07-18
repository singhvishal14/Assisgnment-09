using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_09
{
    public class ValidationException: Exception
    {
        public ValidationException(string message) : base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username, Password, Email;
            try
            {
                Console.WriteLine("Enter Username");
                Username = Console.ReadLine();

                Console.WriteLine("Enter Password");
                Password = Console.ReadLine();

                Console.WriteLine("Enter Email");
                Email = Console.ReadLine();

                if (Username.Length >= 6 && Password.Length >= 8)
                {
                    Console.WriteLine($"entered Username and Password is Valid So: \n Login Successfully!!!!");
                }
                else{
                    if (Username.Length < 6)
                    {
                        throw new ValidationException($"{Username} must be atleast 6 characters");
                    }
                    if (Password.Length < 8)
                    {
                        throw new ValidationException($"{Password} must be atleast 8 characters");
                    }

            }
            }
            catch(ValidationException ex) { Console.WriteLine("Validaton error: "+ex.Message); }
            catch(Exception ex) { Console.WriteLine("Error: "+ex.Message); }
            finally { Console.WriteLine("Program End"); }
            Console.ReadKey();
        }
    }
}
