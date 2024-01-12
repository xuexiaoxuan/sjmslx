using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19命令模式
{
    internal class Invoker
    {
        private Command command;
        public void SetCommand(Command command) { this.command = command;}
        public void ExecuteCommand() { command.Execute(); }
    }
}
