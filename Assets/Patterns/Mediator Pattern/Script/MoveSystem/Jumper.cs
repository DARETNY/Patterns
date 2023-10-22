using Patterns.Mediator_Pattern.Script.Interface;
using UnityEngine;

namespace Patterns.Mediator_Pattern.Script.MoveSystem
{
    public class Jumper : Colleague
    {
        private readonly Transform _target;

        public Jumper(IMediator mediator, Transform target) : base(mediator)
        {
            _target = target;
        }

        public override void Dosomething()
        {
            _target.Translate(Vector3.up);
            

            Mediator.SetterMed(this);
        }
    }
}