using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Command
{
    public class ExampleObject : MonoBehaviour, IMovable, IPaintable
    {
        [SerializeField] private float _moveDistance = 1f;
        [SerializeField] private Image _image; 

        public void Move(Vector3 direction)
        {
            transform.Translate(direction * _moveDistance);
        }

        public Color GetColor()
        {
            if (_image == null)
            {
                Debug.LogError("Image is null");
                return Color.white;
            }
            
            return _image.color;
        }

        public void Paint(Color color)
        {
            if (_image == null)
            {
                Debug.LogError("Image is null");
                return;
            }

            _image.color = color;
        }
    }
}