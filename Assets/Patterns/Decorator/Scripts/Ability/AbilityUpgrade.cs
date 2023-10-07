namespace Patterns.Decorator
{
    public abstract class AbstractAbilityUpgrade : IAbility
    {
        protected readonly IAbility Ability;

        protected AbstractAbilityUpgrade(IAbility ability)
        {
            Ability = ability;
        }
        
        public virtual int GetDamage()
        {
            return Ability.GetDamage();
        }

        public virtual DamageType GetDamageType()
        {
            return Ability.GetDamageType();
        }

        public virtual void DealDamage(IDamagable damagable)
        {
            damagable.DealDamage(Ability.GetDamageType(), Ability.GetDamage());
        }
    }
}