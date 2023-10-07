using System;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Decorator
{
    public class DecoratorPatternController : MonoBehaviour
    {
        [SerializeField] private Button _damageButton;
        [SerializeField] private ExampleUnit _exampleUnit;
        
        private void Start()
        {
            _damageButton.onClick.AddListener(() =>
            {
                OnDamageButtonClick();
            });
        }

        private void OnDamageButtonClick()
        {
            IAbility ability = new Ability(DamageType.Dark, 30);
            ability = new AdditionalDamageAbilityUpgrade(ability, DamageType.Water, 10);
            ability = new AdditionalDamageAbilityUpgrade(ability, DamageType.Fire, 30);
            
            ability.DealDamage(_exampleUnit);
        }
    }
}