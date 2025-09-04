using System.Security.Cryptography.X509Certificates;

namespace The_basic_assigments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String FirstName = "North";
            String favMvie = "Matrix";
            Console.WriteLine("My name is " + FirstName.ToLower() + " and my favorite movie is " + favMvie);
            Console.WriteLine(favMvie.Contains("The"));

        }
    }
}
