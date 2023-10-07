using UnityEngine;

namespace Patterns.Command.MoveCommands
{
    public class MoveDownCommand : AbstractMoveObjectCommand
    {
        public MoveDownCommand(IMovable exampleObject) : base(exampleObject)
        {
        }
        
        public override void Execute()
        {
            MovableObject.Move(Vector3.down);
        }

        public override void Undo()
        {
            MovableObject.Move(Vector3.up);
        }
    }
}