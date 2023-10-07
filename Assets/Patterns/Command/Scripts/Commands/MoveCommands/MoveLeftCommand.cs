using UnityEngine;

namespace Patterns.Command
{
    public class MoveLeftCommand : AbstractMoveObjectCommand
    {
        public MoveLeftCommand(IMovable exampleObject) : base(exampleObject)
        {
        }

        public override void Execute()
        {
            MovableObject.Move(Vector3.left);
        }

        public override void Undo()
        {
            MovableObject.Move(Vector3.right);
        }
    }
}