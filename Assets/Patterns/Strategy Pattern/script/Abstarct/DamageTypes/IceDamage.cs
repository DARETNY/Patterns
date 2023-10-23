using UnityEngine;

namespace Patterns.Strategy_Pattern.script.Abstarct.DamageTypes
{
    public sealed class IceDamage : IDodamage
    {
        public void DoDamage(ushort damage)
        {
            Debug.Log("Freezinnnngggg");
        }
    }
}