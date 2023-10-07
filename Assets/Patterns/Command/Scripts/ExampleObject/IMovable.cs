using UnityEngine;

namespace Patterns.Command
{
    public interface IMovable
    {
        public void Move(Vector3 direction);
    }
}