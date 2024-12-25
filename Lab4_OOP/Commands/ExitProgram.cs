using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Commands
{
    public class ExitProgram : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Program ended");
        }
        public string GetDescription() => "Exit program ";
    }
}
