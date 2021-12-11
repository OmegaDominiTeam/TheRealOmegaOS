using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace OmegaOS
{
    public class Kernel : Sys.Kernel
    {
        static List<string> commandarr = new List<string>() { "help", "about" };
        static string commandarrstring = "help, about";
        protected override void BeforeRun()
        {
            Console.WriteLine("Welcome to OmegaOS");
        }

        protected override void Run()
        {
            Console.Write("Omega> ");
            var input = Console.ReadLine();
            switch (input)
            {
                case "about":
                    Console.WriteLine("OmegaOS v1.0.0");
                    Run();
                    break;
                default:
                    Console.WriteLine(input + " is not a valid command.");
                    input = null;
                    break;
                case "help":
                    Console.WriteLine("Valid commands are " + commandarrstring + ".");
                    break;
                case "neofetch":
                    Console.WriteLine(@"  ____                              ____   _____ 
 / __ \                            / __ \ / ____|
| |  | |_ __ ___   ___  __ _  __ _| |  | | (___  
| |  | | '_ ` _ \ / _ \/ _` |/ _` | |  | |\___ \ 
| |__| | | | | | |  __/ (_| | (_| | |__| |____) |
 \____/|_| |_| |_|\___|\__, |\__,_|\____/|_____/ 
                        __/ |                    
                       |___/");
                    break;

            }
        }
    }
}
