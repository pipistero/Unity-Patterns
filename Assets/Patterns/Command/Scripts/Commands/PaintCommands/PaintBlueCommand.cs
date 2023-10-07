using UnityEngine;

namespace Patterns.Command.PaintCommands
{
    public class PaintBlueCommand : AbstractPaintObjectCommand
    {
        public PaintBlueCommand(IPaintable painatbleObject) : base(painatbleObject)
        {
        }

        public override void Execute()
        {
            _previousColors.Push(PainatbleObject.GetColor());

            PainatbleObject.Paint(Color.blue);
        }
    }
}