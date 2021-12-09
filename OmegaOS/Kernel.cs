using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace OmegaOS
{
    public class Kernel : Sys.Kernel
    {
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
                case "root":
                    Console.Write("Password: ");
                    Console.ReadLine();
                    Run();
                    break;
            }
        }
    }
}
