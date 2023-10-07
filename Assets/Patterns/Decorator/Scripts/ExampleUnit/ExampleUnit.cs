using UnityEngine;

namespace Patterns.Decorator
{
    public class ExampleUnit : MonoBehaviour, IDamagable
    {
        public void DealDamage(DamageType damageType, int damageValue)
        {
            Debug.Log($"Example unit takes {damageValue} {damageType.ToString().ToLower()} damage");
        }
    }
}