using UnityEngine;

namespace Patterns.Command.PaintCommands
{
    public class PaintRedCommand : AbstractPaintObjectCommand
    {
        public PaintRedCommand(IPaintable painatbleObject) : base(painatbleObject)
        {
        }

        public override void Execute()
        {
            _previousColors.Push(PainatbleObject.GetColor());
            
            PainatbleObject.Paint(Color.red);
        }
    }
}