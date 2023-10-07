namespace Patterns.Decorator
{
    public class AdditionalDamageAbilityUpgrade : AbstractAbilityUpgrade
    {
        private DamageType _damageType;
        private int _damageValue;
        
        public AdditionalDamageAbilityUpgrade(IAbility ability, DamageType damageType, int damageValue) : base(ability)
        {
            _damageType = damageType;
            _damageValue = damageValue;
        }

        public override void DealDamage(IDamagable damagable)
        {
            base.DealDamage(damagable);
            
            damagable.DealDamage(_damageType, _damageValue);
        }
    }
}