namespace Patterns.Command.MoveCommands
{
    public abstract class AbstractMoveObjectCommand : ICommand
    {
        protected readonly IMovable MovableObject;

        protected AbstractMoveObjectCommand(IMovable movableObject)
        {
            MovableObject = movableObject;
        }
        
        public abstract void Execute();
        public abstract void Undo();
    }
}