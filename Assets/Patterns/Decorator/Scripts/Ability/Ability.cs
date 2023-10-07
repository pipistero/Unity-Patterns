namespace Patterns.Decorator
{
    public class Ability : IAbility
    {
        protected DamageType _damageType;
        protected int _damageValue;

        public Ability(DamageType damageType, int damageValue)
        {
            _damageType = damageType;
            _damageValue = damageValue;
        }
        
        public int GetDamage()
        {
            return _damageValue;
        }

        public DamageType GetDamageType()
        {
            return _damageType;
        }

        public void DealDamage(IDamagable damagable)
        {
            damagable.DealDamage(_damageType, _damageValue);
        }
    }
}