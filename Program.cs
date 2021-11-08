using System;
using System.Text;

namespace Demo_userdefineattributes
{
  
    class Program
    {
  //      [AuthorAttribute("P. Ackerman", version = 1.1)]
        static void Main(string[] args)
        {
            Console.WriteLine("Demo userdefined Attributes");
            AuthorAttribute A1 = new AuthorAttribute("Chetan bhagat");
            Console.WriteLine("version name \t{0}",A1.version);
          
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public class AuthorAttribute : System.Attribute
    {

        private string WritterName;
        public Double version;

        public AuthorAttribute(string name)
        {
            this.WritterName = name;
            version = 5.0;
            Console.WriteLine("Author name \t{0}",WritterName);

        }
    }
}