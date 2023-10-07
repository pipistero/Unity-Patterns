using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command.PaintCommands
{
    public abstract class AbstractPaintObjectCommand : ICommand
    {
        protected readonly IPaintable PainatbleObject;
        
        protected Stack<Color> _previousColors = new Stack<Color>(); 

        protected AbstractPaintObjectCommand(IPaintable painatbleObject)
        {
            PainatbleObject = painatbleObject;
        }

        public abstract void Execute();

        public void Undo()
        {
            if (_previousColors.Count == 0)
                PainatbleObject.Paint(Color.white);
            else
                PainatbleObject.Paint(_previousColors.Pop());
        }
    }
}