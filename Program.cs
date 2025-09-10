using System.Security.Cryptography.X509Certificates;

namespace The_basic_assigments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String FirstName = "North";
            String favMvie = "Matrix";
            String favquote = "Life moves pretty fast. If you don't stop and look around once in a while, you could miss it";
           
            favMvie = favMvie.ToUpper();
            Console.WriteLine("My name is " + FirstName.ToLower() + " and my favorite movie is " + favMvie);
            Console.WriteLine(favMvie.Contains("THE"));
            // replace all the vowles in fav quote with "a"

            favquote= favquote.Replace("a", " ");
            favquote = favquote.Replace("e", " ");
            favquote = favquote.Replace("i", " ");
            favquote = favquote.Replace("o", " ");
            favquote = favquote.Replace("u", " ");
            Console.WriteLine(favquote.Replace("a,e,i,o,u", " "));
            Console.WriteLine(favquote);

            
            Console.Write("    /|         ,                 ");                 Console.WriteLine(".,--.");
            Console.Write("              ,///        /|     ");     Console.WriteLine(".' __  \\");
            Console.Write("             // //     ,///      ");      Console.WriteLine("| .._  |");
            Console.Write("            // //     // //      ");      Console.WriteLine("|{)(} .'");
            Console.Write("           // //     || ||       ");       Console.WriteLine("/ /|  |.");
            Console.Write("           || ||    // //        ");        Console.WriteLine("(_/ /____)"); 
            Console.Write("           || ||   // //         ");         Console.WriteLine("|_||");
            Console.Write("           || ||  // //          ");          Console.WriteLine("/'");
            Console.Write("           || || || ||           ");           Console.WriteLine("//"); 
            Console.Write("           \\,\\|,|\\_//         ");         Console.WriteLine(".'''\\");
            Console.Write("            \\\\)\\)\\\\|/       ");       Console.WriteLine("/\\:::/\\");
            Console.Write("            )-.\"\" .-(          ");          Console.WriteLine("( /|::|\\");
            Console.Write("           //^\\` `/^\\\\        ");        Console.WriteLine("_\\:|;;|{/_");
            Console.Write("          //  |   |  \\\\        ");        Console.WriteLine("'.;|**|\\;,/");
            Console.Write("        ,/_| 0| _ | 0|_\\,       ");       Console.WriteLine("\\_ /");
            Console.Write("      /`    `\"=.v.=\"`    `\\   ");   Console.WriteLine("| ||");
            Console.Write("     /`    _.\"{_,_}\"._    `\\  ");  Console.WriteLine("| ||");
            Console.Write("jgs  `/`  ` \\  |||  / `  `\\`   ");   Console.WriteLine("| ||");
            Console.Write("      `\",_  \\\\=^~^=//  _,\"`  ");  Console.WriteLine("| ||");
            Console.Write("          \"=,\\'-=-'/,=\"       ");       Console.WriteLine("._| ||_.");
            Console.Write("              '---'              ");              Console.WriteLine(";,_.-._,;");



        }
    }
}
