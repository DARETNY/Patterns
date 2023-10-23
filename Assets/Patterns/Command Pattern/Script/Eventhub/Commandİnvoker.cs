using System.Collections.Generic;
using Patterns.Command_Pattern.Script.Interface;

namespace Patterns.Command_Pattern.Script.Eventhub
{
    public class Commandİnvoker
    {
        private readonly Stack<ICommand> _commandStack = new();
       
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandStack.Push(command);
            
        }

        public void UndoCommand()
        {
            if (_commandStack.Count>0)
            {
                _commandStack.Pop().Undo();
            }
            
        }
    }
}