namespace Patterns.Decorator
{
    public interface IAbility
    {
        public int GetDamage();
        public DamageType GetDamageType();
        public void DealDamage(IDamagable damagable);
    }
}