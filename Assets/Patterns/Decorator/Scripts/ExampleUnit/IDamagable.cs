namespace Patterns.Decorator
{
    public interface IDamagable
    {
        public void DealDamage(DamageType damageType, int damageValue);
    }
}