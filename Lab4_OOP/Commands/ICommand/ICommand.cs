using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_OOP.Commands
{
    public interface ICommand
    {
        void Execute();
        string GetDescription();
    }
}
