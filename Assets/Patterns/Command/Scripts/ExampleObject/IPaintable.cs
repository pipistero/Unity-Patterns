using UnityEngine;

namespace Patterns.Command
{
    public interface IPaintable
    {
        public Color GetColor();
        public void Paint(Color color);
    }
}