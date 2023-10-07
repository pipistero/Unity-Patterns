using UnityEngine;

namespace Patterns.Command.PaintCommands
{
    public class PaintGreenCommand : AbstractPaintObjectCommand
    {
        public PaintGreenCommand(IPaintable painatbleObject) : base(painatbleObject)
        {
        }

        public override void Execute()
        {
            _previousColors.Push(PainatbleObject.GetColor());
            
            PainatbleObject.Paint(Color.green);
        }
    }
}