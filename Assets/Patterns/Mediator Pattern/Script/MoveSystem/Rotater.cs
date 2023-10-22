using Patterns.Mediator_Pattern.Script.Interface;
using UnityEngine;

namespace Patterns.Mediator_Pattern.Script.MoveSystem
{
    public class Rotater : Colleague
    {
        private readonly Transform _target;

        public Rotater(IMediator mediator, Transform target) : base(mediator)
        {
            _target = target;
        }

        
        public override void Dosomething()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            _target.RotateAround(Vector3.up, 45 * Time.deltaTime);
#pragma warning restore CS0618 // Type or member is obsolete
            Mediator.SetterMed(this);
        }
    }
}