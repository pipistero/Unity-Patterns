using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}

