using UnityEngine;

namespace Patterns.Strategy_Pattern.script.Abstarct.DamageTypes
{
    public class IceDamage : IDodamage
    {
        public void DoDamage(ushort damage)
        {
            Debug.Log("Freezinnnngggg");
        }
    }
}