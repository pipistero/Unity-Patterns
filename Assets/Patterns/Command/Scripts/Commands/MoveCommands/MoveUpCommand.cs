using UnityEngine;

namespace Patterns.Command.MoveCommands
{
    public class MoveUpCommand : AbstractMoveObjectCommand
    {
        public MoveUpCommand(IMovable exampleObject) : base(exampleObject)
        {
        }

        public override void Execute()
        {
            MovableObject.Move(Vector3.up);
        }

        public override void Undo()
        {
            MovableObject.Move(Vector3.down);
        }
    }
}