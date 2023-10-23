using UnityEngine;

namespace Patterns.Strategy_Pattern.script.Abstarct.DamageTypes
{
    public sealed class ToxicDamage : IDodamage
    {
        public void DoDamage(ushort damage)
        {
            
            // you can do something there like crit damage or extra damage vs...
            Debug.Log("AAAAAA");
        }
    }

    // you can use the enum type to control the all elements
}