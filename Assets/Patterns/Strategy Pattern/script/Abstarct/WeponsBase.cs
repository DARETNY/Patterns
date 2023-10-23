namespace Patterns.Strategy_Pattern.script.Abstarct
{
    public abstract class WeponsBase 
    {
        private IDodamage _dodamage;
        private readonly ushort _damage;

        public ushort TryAttack()
        {
            _dodamage?.DoDamage(_damage);
            return _damage;
        }


        protected void SetDamagetype(IDodamage dodamage)
        {
            _dodamage = dodamage;
        }

        protected WeponsBase(IDodamage dodamage, ushort damage)
        {
            _dodamage = dodamage;
            _damage = damage;
        }
    }
}