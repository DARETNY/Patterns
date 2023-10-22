using Patterns.Strategy_Pattern.script.Abstarct;

namespace Patterns.Strategy_Pattern.script.Commands
{
    public sealed class RifleGun : WeponsBase
    {
        public RifleGun(IDodamage dodamage, ushort damage) : base(dodamage, damage)
        {
            base.SetDamagetype(dodamage);
        }


        
    }
}