using System.Collections;

namespace Patterns.Command_Pattern.Script.Interface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}