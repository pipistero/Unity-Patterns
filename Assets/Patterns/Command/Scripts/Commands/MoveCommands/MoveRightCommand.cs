using UnityEngine;

namespace Patterns.Command
{
    public class MoveRightCommand : AbstractMoveObjectCommand
    {
        public MoveRightCommand(IMovable movableObject) : base(movableObject)
        {
        }

        public override void Execute()
        {
            MovableObject.Move(Vector3.right);
        }

        public override void Undo()
        {
            MovableObject.Move(Vector3.left);
        }
    }
}